using DemoShapeData.Helper;
using DemoShapeData.Logic;
using Microsoft.AspNetCore.Mvc;

namespace DemoShapeData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductLogic _productLogic;
        public ProductController()
        {
            _productLogic = new ProductLogic();
        }

        [HttpGet]
        public IActionResult Get([FromQuery] string fields = null)
        {
            return Ok(_productLogic.GetProductsList().ShapeData(fields));
        }

    }



}
