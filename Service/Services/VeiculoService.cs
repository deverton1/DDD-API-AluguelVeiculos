using CreditCardValidator;
using Domain.Commands;
using Domain.Enums;
using Domain.Interfaces;
using Domain.ViewModel;
using System.Net.Http.Headers;

namespace Service.Services
{
    public class VeiculoService : IVeiculoService
    {
        //Injeção de dependencia

        private readonly IVeiculoRepository _repository;

        public VeiculoService(IVeiculoRepository repository)
        {
            _repository = repository;
        }
        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostAsync(VeiculoCommand command)
        {
            if (command == null)
                return "Todos os Campos são Obrigatórios";

            int anoAtual = DateTime.Now.Year;
            if (anoAtual - command.AnoFabricacao > 5)
                return "O Ano do veículo é menor que o permitido";

            if (command.TipoVeiculo != ETipoVeiculo.SUV
               && command.TipoVeiculo != ETipoVeiculo.Hatch
               && command.TipoVeiculo != ETipoVeiculo.Sedan
            )
                return "O Tipo de Veículo não pe permitido";

            return await _repository.PostAsync(command);
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<VeiculoCommand>> GetVeiculosDisponiveis()
        {
            return await _repository.GetVeiculosDisponiveis();
        }

        public async Task<SimularVeiculoAluguelViewModel> SimularVeiculoAluguel(int totalDiasSimulado, ETipoVeiculo tipoVeiculo)
        {
            var veiculoPreco = await _repository.GetPrecoDiaria(tipoVeiculo);
            if (totalDiasSimulado > veiculoPreco.PeriodoMaximoAluguel)
                return null;
            double taxaEstadual = 10.5;
            double taxaFederal = 3.5;
            double taxaMunicipal = 13.5;

            var simulacao = new SimularVeiculoAluguelViewModel();
            simulacao.TotalDiasSimulado = totalDiasSimulado;
            simulacao.Taxas = (decimal)(taxaMunicipal + taxaEstadual + taxaFederal);
            simulacao.TipoVeiculo = tipoVeiculo;
            simulacao.ValorDiaria = veiculoPreco.Preco;
            simulacao.ValorTotal = (totalDiasSimulado * veiculoPreco.Preco) + simulacao.Taxas;

            return simulacao;
        }

        public async Task AlugarVeiculo(AlugarVeiculoVielModelInput input)
        {
            var veiculoDisponivel = await ValidarDisponibilidadeVeiculo(input.PlacaVeiculo);
            if (veiculoDisponivel)
            {
                //  "este veículo não está mais disponível";
            }


            //to do
            //chamar metodo para datas validas que nao podem ser menores que o da data disponivel           
           if (await ValidarDatas(input.DataRetirada,input.DataDevolucao))
            {
                //"Data inválida"
            }






            //to do 
            //chamar metodo para validar cartao
            CreditCardDetector detector = new CreditCardDetector(Convert.ToString(input.Cartao.Numero));
            var bandeira = detector.Brand; // => 4012888888881881
            if (!detector.IsValid()) // => True
            {
                //"Cartão Inválido";
            }




            //to do
            //chamar metodo para validar habilitação

        }
        //validação para verificar se o veículo está disponível
        private Task<bool> ValidarDisponibilidadeVeiculo(string placaVeiculo)
        {
            return _repository.ValidarDisponibilidadeVeiculo(placaVeiculo);
        }

        //validação com condições para receber apenas datas válidas
        private async Task<bool> ValidarDatas(DateTime inicio, DateTime fim)
        {
            if (inicio < fim)
                return false;
            else if (inicio == fim)
                return false;
            else if (fim < DateTime.Now)
                return false;
            else if (inicio < DateTime.Now)
                return false;
            else
                return true;

        }
    }
}
