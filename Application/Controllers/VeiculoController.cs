using Domain.Commands;
using Domain.Enums;
using Domain.Interfaces;
using Domain.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Services;
using System.Linq.Expressions;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculoService _veiculoService;
        public VeiculoController(IVeiculoService veiculoService)
        {
           _veiculoService = veiculoService;
        }
        #region Post
        [HttpPost]
        [Route("CadastrarVeiculo")]
        public async Task<IActionResult> PostAsync([FromBody] VeiculoCommand command)
        {
            return Ok(await _veiculoService.PostAsync(command));
        }
                  
        [HttpPost]
        [Route("Alugar")]
        public async Task<IActionResult> PostAsync([FromBody]AlugarVeiculoVielModelInput input)
        {
            await _veiculoService.AlugarVeiculo(input);
            return Ok();
        }


        #endregion

        [HttpGet]
        [Route("SimularAluguel")]
        public async Task<IActionResult> GetAsync(int DiasSimularAluguel, ETipoVeiculo tipoVeiculo) 
        {
            return Ok(await _veiculoService.SimularVeiculoAluguel(DiasSimularAluguel, tipoVeiculo));
        }
        [HttpGet]
        [Route("Veiculos-Disponiveis")]
        public async Task<IActionResult> GetVeiculosDisponiveis()
        {
            return Ok(await _veiculoService.GetVeiculosDisponiveis());
        }
        
    }
}
