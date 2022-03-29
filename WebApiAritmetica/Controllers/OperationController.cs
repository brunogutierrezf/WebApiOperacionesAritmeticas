using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiAritmetica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
         [HttpGet]
         [Route("Sum")]
         public int Sum(
             int numa,
             int numb)
        {
            return numa + numb;
        }
        [HttpPost]
        [Route("Sum")]
        public int SumPost( 
            [FromHeader]int numa,
            [FromHeader] int numb)
        {
            return numa + numb;
        }
        [HttpGet]
        [Route("Resta")]
        public int Resta(
             int numa,
             int numb)
        {
            return numa - numb;
        }
        [HttpPost]
        [Route("Resta")]
        public int RestaPost(
            [FromHeader] int numa,
            [FromHeader] int numb)
        {
            return numa - numb;
        }

        [HttpGet]
        [Route("Multiplicacion")]
        public int Multiplicacion(
                int numa,
                int numb)
        {
            return numa * numb;
        }
        [HttpPost]
        [Route("Multiplicacion")]
        public int MultiplicacionPost(
            [FromHeader] int numa,
            [FromHeader] int numb)
        {
            return numa * numb;
        }
        [HttpGet]
        [Route("Division")]
        public int Division(
               int numa,
               int numb)
        {
            return numa / numb;
        }
        [HttpPost]
        [Route("Division")]
        public int DivisionPost(
            [FromHeader] int numa,
            [FromHeader] int numb)
        {
            return numa / numb;
        }
    }
}
