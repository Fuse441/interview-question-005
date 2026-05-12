using interview_question_005.Services;
using Microsoft.AspNetCore.Mvc;

namespace interview_question_005.Controllers;

[ApiController]
[Route("api/queue")]
public class QueueController : ControllerBase
{
    private readonly QueueService _queueService;

    public QueueController(QueueService queueService)
    {
        _queueService = queueService;
    }

    [HttpGet]
    public IActionResult GetQueue()
    {
        return Ok(new { queue = _queueService.GetCurrentQueue() });
    }

    [HttpPost("take")]
    public IActionResult TakeQueue()
    {
        var queue = _queueService.GenerateNextQueue();

        return Ok(new { queue });
    }

    [HttpPost("reset")]
    public IActionResult ResetQueue()
    {
        var queue = _queueService.ResetQueue();

        return Ok(new { queue });
    }
}
