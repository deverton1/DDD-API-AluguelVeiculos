using Domain.Commands;

namespace Domain.Interfaces
{
    public interface IClienteRepository
    {
        Task<string> PostAsync(ClienteCommand command);
    }
}
