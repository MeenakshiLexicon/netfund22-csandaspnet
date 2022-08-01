using _00_Repetition_WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _00_Repetition_WebApi.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // Http Methods: GET,POST,PUT,DELETE
        // Status Codes: 200 OK, 201 CREATED, 204 NO CONTENT, 400 BAD REQUEST, 401 UNAUTHORIZED, 403 FORBIDDEN, 404 NOT FOUND, 409 CONCLICT, 500 INTERNAL SERVER ERROR

        [HttpGet]
        public IActionResult GetAll()
        {
            return new OkResult();
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            return new OkResult();
        }

        [HttpPost]
        public IActionResult CreateOne(Product product)
        {
            return new OkResult();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateOne(int id, Product product)
        {
            return new OkResult();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOne(int id)
        {
            return new OkResult();
        }

    }
}
