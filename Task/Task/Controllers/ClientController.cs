using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task.DTO;
using Task.Models;
using Task.Repositories;

namespace Task.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        IClientRepository clientRepository;
        public ClientController(IClientRepository clientRepo)
        {
            clientRepository = clientRepo;
        }
        [HttpPost]
        public IActionResult PostClient(ClientDTO client)
        {
            if(ModelState.IsValid)
            {
                clientRepository.Insert(client);
                return Created("http://localhost:5034/Product", client);
            }
            return BadRequest(ModelState);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(clientRepository.GetAll());
        }
    }
}
