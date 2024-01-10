using Microsoft.AspNetCore.Mvc;
using MiniChallenges5To7.Services.MiniChallenge7_Num;

namespace MiniChallenges5To7.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChallenge7_NumController : ControllerBase
{
    private readonly IMiniChallenge7_NumService _miniChallenge7_NumService;

    public MiniChallenge7_NumController(IMiniChallenge7_NumService miniChallenge7_NumService)
    {
        _miniChallenge7_NumService = miniChallenge7_NumService;
    }

    [HttpGet]
    [Route("CallPrompt")]
     public List<string> CallPrompt()
    {
        return _miniChallenge7_NumService.CallPrompt();
    }

    [HttpPut]
    [Route("ReverseNum/{userInput}")]
    public List<string> ReverseNum(string userInput)
    {
        return _miniChallenge7_NumService.ReverseNum(userInput);
    }
}
