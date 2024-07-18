
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using BusinessBook.Data;
using BusinessBook.Models;

namespace BusinessBook.Controllers;

[ApiController]
[Route("api/Dashboard")]
public class DashboardController : ControllerBase
{
    private readonly MongoDbContext _context;

    private readonly ILogger<DashboardController> _logger;

    public DashboardController(MongoDbContext context, ILogger<DashboardController> logger)
    {
        _context = context;
        _logger = logger;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<MoneyDetails>> Get(string id)
    {
        var article = await _context.MoneyDetail.Find(a => a.Id == id).FirstOrDefaultAsync();

        if (article == null)
        {
            return NotFound();
        }

        return Ok(article);
    }
}

