using CRUD_Assignment.IRepository;
using CRUD_Assignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinkController : ControllerBase
    {
        private IDrinkRepository _repository;

        public DrinkController(IDrinkRepository repository)
        {
            _repository = repository;

        }

        [HttpGet]
        [Route("Index")]
        public async Task<IActionResult> index()
        {
            var result =await _repository.GetAllAsync();
            return Ok(result);
        }
        [HttpGet]
        [Route("GetById")]
        public  async Task<IActionResult> GetById(int id)
        {
            Drink result =await _repository.GetDrinkByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        [Route("Creates")]
        public async Task<IActionResult> Creates(Drink drink)
        {
            int result =await _repository.CreateDrinkAsync(drink);

            if (result <= 0)
            {
                return BadRequest("Failed");
            }
            else
            {
                return Ok("Add" + result);
            }

        }
        [HttpPut]
        [Route("Edit")]
        public async Task<IActionResult> Edit(Drink drink)
        {
            int result =await _repository.UpdateDrinkAsync(drink);

            if (result <= 0)
            {
                return BadRequest("Failed");
            }
            else
            {
                return Ok("Edit" + result);
            }

        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            int result =await _repository.DeleteDrinkAsync(id);

            if (result <= 0)
            {
                return BadRequest("Failed");
            }
            else
            {
                return Ok("Deleted" + result);
            }

        }

        [HttpGet]
        [Route("TotalSum")]

        public async Task<IActionResult> TotalSum()
        {
            var result = await _repository.TotalPriceAsync();

            return Ok("TotalPrice: " + result);
        }

        [HttpGet]
        [Route("DeleteByQuantity")]

        public async Task<IActionResult> DeleteByQuantity()
        {
            var result = await _repository.DeleteByQuantityAsync();
            return Ok("Deleted" + result);
        }


    }
}
