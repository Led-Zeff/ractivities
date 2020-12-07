using System.Collections.Generic;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Persistence;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ValuesController : ControllerBase
  {
    private readonly DataContext _dataContext;

    public ValuesController(DataContext dataContext)
    {
        this._dataContext = dataContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Value>>> Get()
    {
        var values = await _dataContext.Values.ToListAsync();
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Value>> Get(int id)
    {
        var value = await _dataContext.Values.FindAsync(id);
        return Ok(value);
    }

    [HttpPost]
    public void Post([FromBody] string value)
    {

    }
  }
}