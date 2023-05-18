using Microsoft.AspNetCore.Mvc;

namespace Counter.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CounterController : ControllerBase
{
    private readonly Counter _counter;

    public CounterController()
    {
        _counter = new Counter();
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_counter.Count);
    }

    [HttpPut]
    public IActionResult Put()
    {
        _counter.Start();
        return Ok(_counter.Count);
    }

    [HttpPost("start")]
    public IActionResult Start()
    {
        _counter.Start();
        return Ok($"Counter is started. Count is {_counter.Count}");
    }

    [HttpPost("stop")]
    public IActionResult Stop()
    {
        _counter.Stop();
        return Ok("Counter is stopped");
    }
}
