namespace MiniChallenges5To7.Services.MiniChallenge5;

public interface IMiniChallenge5Service
{
    List<string> MakeStory(string nameOne, string pronoun, string nounOne, string warriorsWeapon, string creatureOne, string locationOne, string nameTwo, string ageOne, string toolOne, string pocketItem);
    List<string> CallPrompt();
}