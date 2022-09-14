using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task.Repositories;

namespace Task.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        IBankRepository bankRepository;
        public BankController(IBankRepository bankRepo)
        {
            bankRepository = bankRepo;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(bankRepository.GetAll());
        }
    }
}
