namespace snakeChart.Controllers;
[ApiController]
[Route("api/[controller]")]
public class SerpentsController : ControllerBase
{
    private readonly SerpentsService _serpentsService;
    public SerpentsController(SerpentsService serpentsService)
    {
        _serpentsService = serpentsService;
    }
    [HttpGet]
    public ActionResult<List<Serpent>> GetSerpents()
    {
        try
        {
            List<Serpent> serpents = _serpentsService.GetSerpents();
            return Ok(serpents);
        }
        catch (Exception error)
        {

            return BadRequest(error.Message);
        }
    }
    [HttpGet("{serpentId}")]
    public ActionResult<Serpent> GetSerpentById(int serpentId)
    {
        try
        {
            Serpent serpent = _serpentsService.GetSerpentById(serpentId);
            return Ok(serpent);
        }
        catch (Exception error)
        {

            return BadRequest(error.Message);
        }
    }
    [HttpPost]
    public ActionResult<Serpent> CreateSerpent([FromBody] Serpent serpentData)
    {
        try
        {
            Serpent serpent = _serpentsService.CreateSerpent(serpentData);
            return Ok(serpent);
        }
        catch (Exception error)
        {

            return BadRequest(error.Message);
        }
    }
    [HttpDelete("{serpentId}")]
    public ActionResult<string> DestroySerpent(int serpentId)
    {
        try
        {
            string message = _serpentsService.DestroySerpent(serpentId);
            return Ok(message);
        }
        catch (Exception error)
        {

            return BadRequest(error.Message);
        }
    }
    [HttpPut("{serpentId}")]
    public ActionResult<Serpent> EditSerpent(int serpentId, [FromBody] Serpent serpentData)
    {
        try
        {
            Serpent serpent = _serpentsService.EditSerpent(serpentData, serpentId);
            return Ok(serpent);
        }
        catch (Exception error)
        {

            return BadRequest(error.Message);
        }
    }
}