using Microsoft.AspNetCore.Mvc;
using Product_Management_System.Models;
using Product_Management_System.Services.Admin;

namespace Product_Management_System.Controllers
{
    [Authentication]
    public class ShopController : Controller
    {
        private readonly IProductService _productService;

        public ShopController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var result = await _productService.GetAllProduct();
                return View(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Details(int Id)
        {
            try
            {
                var result = await _productService.GetProductById(Id);
                if (result != null)
                {
                    return View(result);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
