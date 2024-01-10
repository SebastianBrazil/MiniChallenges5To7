namespace MiniChallenges5To7.Services.MiniChallenge7_Num;

public class MiniChallenge7_NumService : IMiniChallenge7_NumService
{
    public List<string> prompt = new();

    public MiniChallenge7_NumService()
    {
        prompt.Add("Any numerical sequence you give me, I shall reverse it.");
    }

    public List<string> CallPrompt()
    {
        return prompt;
    }

    public List<string> ReverseNum(string userInput)
    {
        int numero1;
        bool parsed = false;
        if (parsed = int.TryParse(userInput, out numero1))
        {
            prompt.Add($"You chose the number {userInput}.");
            int result = 0;
            while (numero1 > 0)
            {
                result = result * 10 + numero1 % 10;
                numero1 /= 10;
            }
            if(Convert.ToString(userInput[0]) == "0"){
                string strResult = Convert.ToString(result);
                strResult+="0";
                prompt.Add(strResult);
                result = Convert.ToInt32(strResult);
            }
            prompt.Add($"The reverse of {userInput} is {result}.");
        }
        else
        {
            prompt.Add($"{userInput} is not a clear numerical sequence.");
        }
        return prompt;
    }
}