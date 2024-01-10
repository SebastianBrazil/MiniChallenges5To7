namespace MiniChallenges5To7.Services.MiniChallenge7;

public class MiniChallenge7Service : IMiniChallenge7Service
{
    public List<string> prompt = new();

    public MiniChallenge7Service()
    {
        prompt.Add("Any phrase you give me, I shall reverse it.");
    }

    public List<string> CallPrompt()
    {
        return prompt;
    }

    public List<string> ReversePhrase(string userInput)
    {
        prompt.Add($"You chose the phrase {userInput}.");
        string reversedUserInput = "";
        for (int i = userInput.Length - 1; i >= 0; i--)
        {
            reversedUserInput += userInput[i];
        }
        prompt.Add($"The reverse of {userInput} is {reversedUserInput}");
        return prompt;
    }
}