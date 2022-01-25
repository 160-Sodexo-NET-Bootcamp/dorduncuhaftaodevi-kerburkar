using Data.UOW;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnicalErrorController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<TechnicalErrorController> _logger;
        public TechnicalErrorController(IUnitOfWork unitOfWork, ILogger<TechnicalErrorController> logger)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        //Tüm vehicle listesini göstermek için kullanıldı.
        //get işlemlerinde gelen data model dto'a map edildi. post işlemlerinde kullanıcıdan gelen dto data model'e map edildi.

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _unitOfWork.TechnicalError.GetAll();
            //Response tipleri data model yerine dto olarak gerekli dönüşümler yapıldı.
            return Ok(result);

        }
    }
}
