using Microsoft.AspNetCore.Mvc;
using MiniChallenges5To7.Services.MiniChallenge5;

namespace MiniChallenges5To7.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChallenge5Controller : ControllerBase
{
    private readonly IMiniChallenge5Service _miniChallenge5Service;

    public MiniChallenge5Controller(IMiniChallenge5Service miniChallenge5Service)
    {
        _miniChallenge5Service = miniChallenge5Service;
    }

    [HttpGet]
    [Route("CallPrompt")]
     public List<string> CallPrompt()
    {
        return _miniChallenge5Service.CallPrompt();
    }

    [HttpPut]
    [Route("MakeStory/{input1}/{input2}/{input3}/{input4}/{input5}/{input6}/{input7}/{input8}/{input9}/{input10}")]
    public List<string> MakeStory(string input1, string input2, string input3, string input4, string input5, string input6, string input7, string input8, string input9, string input10)
    {
        return _miniChallenge5Service.MakeStory(input1, input2, input3, input4, input5, input6, input7, input8, input9, input10);
    }
}
