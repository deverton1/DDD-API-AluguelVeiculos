using Domain.Commands;
using Domain.Enums;

namespace Domain.Interfaces
{
    public interface IVeiculoRepository
    {
        Task<string> PostAsync(VeiculoCommand command);
        void PostAsync();
        void GetAsync();
        Task<IEnumerable<VeiculoCommand>> GetVeiculosDisponiveis();
        Task<VeiculoPrecoCommand> GetPrecoDiaria(ETipoVeiculo tipoVeiculo);
        Task<bool> ValidarDisponibilidadeVeiculo(string placaVeiculo);
        Task<DateTime> ValidarRetirada(DateTime dataDaRetirada);
        Task<DateTime> ValidarDevolucao(DateTime dataDaDevolucao);
    }
}
