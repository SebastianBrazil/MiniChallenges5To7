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
    [Route("MakeStory/{nameOne}/{pronoun}/{nounOne}/{warriorsWeapon}/{creatureOne}/{locationOne}/{nameTwo}/{ageOne}/{toolOne}/{pocketItem}")]
    public List<string> MakeStory(string nameOne, string pronoun, string nounOne, string warriorsWeapon, string creatureOne, string locationOne, string nameTwo, string ageOne, string toolOne, string pocketItem)
    {
        return _miniChallenge5Service.MakeStory(nameOne, pronoun, nounOne, warriorsWeapon, creatureOne, locationOne, nameTwo, ageOne, toolOne, pocketItem);
    }
}
