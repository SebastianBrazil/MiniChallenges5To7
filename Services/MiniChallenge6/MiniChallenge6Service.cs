namespace MiniChallenges5To7.Services.MiniChallenge6;

public class MiniChallenge6Service : IMiniChallenge6Service
{
    public List<string> prompt = new();

    public MiniChallenge6Service()
    {
        prompt.Add("Any number you give me, I shall determine if it is even or odd.");
        prompt.Add("Number");
    }

    public List<string> CallPrompt()
    {
        return prompt;
    }

    public List<string> GivenNumbs(string num)
    {
        prompt[1] = num;
        double parsedNum;

        bool parsed = true;
        if (parsed != double.TryParse(num, out parsedNum))
        {
            prompt.Add("Your input was not a valid number. It is not comparable.");
        }
        else
        {
            if (parsedNum % 2 == 0)
            {
                prompt.Add($"{parsedNum} is an even number. Yippee");
            }
            else
            {
                prompt.Add($"{parsedNum} is an odd number. Yippee");
            }
        }
        return prompt;
    }
}