using Domain.Commands;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        public ClienteController(IClienteService clienteService)
        {
                _clienteService = clienteService;
        }
        [HttpPost]
        [Route("CriarCliente")]
        public async Task<IActionResult> PostAsync(ClienteCommand command)
        {
            return Ok(await _clienteService.PostAsync(command));
        }

    }
}
