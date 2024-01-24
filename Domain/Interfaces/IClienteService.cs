using Domain.Commands;

namespace Domain.Interfaces
{
    public interface IClienteService
    {
        Task<string> PostAsync(ClienteCommand command);
    }
}
