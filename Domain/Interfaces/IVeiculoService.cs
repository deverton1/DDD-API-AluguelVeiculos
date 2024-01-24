using Domain.Commands;
using Domain.Enums;
using Domain.ViewModel;

namespace Domain.Interfaces
{
    public interface IVeiculoService
    {
        //A interface é um contrato, apenas usamos para adicionar
        //metodos,
        //não é feita implementação de nada

        Task<string> PostAsync(VeiculoCommand command);
        void PostAsync();
        void GetAsync();
        Task<IEnumerable<VeiculoCommand>> GetVeiculosDisponiveis();
        Task<SimularVeiculoAluguelViewModel> SimularVeiculoAluguel(int TotalDiasSimulado, ETipoVeiculo tipoVeiculo);
        Task AlugarVeiculo(AlugarVeiculoVielModelInput input);
    }
}
