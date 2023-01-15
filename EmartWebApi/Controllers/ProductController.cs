using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using EmartWebApi.DAL;
using EmartWebApi.Model;

namespace EmartWebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{

    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [EnableCors()]
    public IEnumerable<Product> GetAllProducts()
    {
        List<Product>products=ProductManager.GetAllProducts();
        return products;
    }

    [Route("{id}")]
    [HttpGet]
    [EnableCors()]
    public ActionResult<Product> GetProductById(int id)
    {
        
        Product product=ProductManager.GetProductById(id);
        return product;
    }

    [HttpPost]
    [EnableCors()]
    public IActionResult InsertNewProduct(Product product)
    {
        ProductManager.SaveProduct(product);
        return Ok(new {message="Product Created"});
    }

    [Route("{id}")]
    [HttpDelete]
    [EnableCors()]
    public ActionResult Delete(int id)
    {
        ProductManager.DeleteProduct(id);
        return Ok(new {message="Deleted"});
    }
       

    
}
