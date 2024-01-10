namespace MiniChallenges5To7.Services.MiniChallenge5;

public interface IMiniChallenge5Service
{
    List<string> MakeStory(string input1, string input2, string input3, string input4, string input5, string input6, string input7, string input8, string input9, string input10);
    List<string> CallPrompt();
}