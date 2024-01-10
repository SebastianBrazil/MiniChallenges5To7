using Microsoft.AspNetCore.Mvc;
using MiniChallenges5To7.Services.MiniChallenge7;

namespace MiniChallenges5To7.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChallenge7Controller : ControllerBase
{
    private readonly IMiniChallenge7Service _miniChallenge7Service;

    public MiniChallenge7Controller(IMiniChallenge7Service miniChallenge7Service)
    {
        _miniChallenge7Service = miniChallenge7Service;
    }

    [HttpGet]
    [Route("CallPrompt")]
     public List<string> CallPrompt()
    {
        return _miniChallenge7Service.CallPrompt();
    }

    [HttpPut]
    [Route("ReversePhrase/{userInput}")]
    public List<string> ReversePhrase(string userInput)
    {
        return _miniChallenge7Service.ReversePhrase(userInput);
    }
}
