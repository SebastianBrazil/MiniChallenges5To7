using Microsoft.AspNetCore.Mvc;
using MiniChallenges5To7.Services.MiniChallenge6;

namespace MiniChallenges5To7.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChallenge6Controller : ControllerBase
{
    private readonly IMiniChallenge6Service _miniChallenge6Service;

    public MiniChallenge6Controller(IMiniChallenge6Service miniChallenge6Service)
    {
        _miniChallenge6Service = miniChallenge6Service;
    }

    [HttpGet]
    [Route("CallPrompt")]
     public List<string> CallPrompt()
    {
        return _miniChallenge6Service.CallPrompt();
    }

    [HttpPut]
    [Route("GivenNumbs/{num}")]
    public List<string> GivenNumbs(string num)
    {
        return _miniChallenge6Service.GivenNumbs(num);
    }
}