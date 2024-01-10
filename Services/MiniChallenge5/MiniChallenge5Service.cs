namespace MiniChallenges5To7.Services.MiniChallenge5;

public class MiniChallenge5Service : IMiniChallenge5Service
{
    public List<string> prompt = new();

    public MiniChallenge5Service()
    {
        prompt.Add("Do you want to read in incredibly dysfunctional story that has no rhyme or reason? Do you want a hand in *making* said story? Either way, you have no choice.");

        prompt.Add("Think of a 'name'.");
        prompt.Add("Give a singular 'pronoun' to describe this person. Ex. He/She/They");
        prompt.Add("Think of '(a) noun' to use.");
        prompt.Add("Think of '(an) instrument' to use.");
        prompt.Add("Think of some 'creatures'.");
        prompt.Add("Think of a 'name' to use, preferably to a location.");
        prompt.Add("Think of another 'name' to use.");
        prompt.Add("Think of a 'number' to use.");
        prompt.Add("Think of the name of a 'utensil' to use");
        prompt.Add("Think of the name of'(an) object' to use, preferably pocket-sized.");
    }

    public List<string> CallPrompt()
    {
        return prompt;
    }

    public List<string> MakeStory(string input1, string input2, string input3, string input4, string input5, string input6, string input7, string input8, string input9, string input10)
    {
        string nameOne = input1;
        string pronoun = input2;
        string nounOne = input3;
        string warriorsWeapon = input4;
        string creatureOne = input5;
        string locationOne = input6;
        string nameTwo = input7;
        string ageOne = input8;
        string toolOne = input9;
        string pocketItem = input10;

        prompt = new();

        prompt.Add($"There once was a dwarf named {nameOne}. {pronoun} was on the hunt for {nounOne} inside a dragon's lair. {pronoun} only carries {warriorsWeapon} to play kicking toons for the boys at the tavern. {nameOne} crossed gueling mountain passes and treacherous rivers, only to see a hoard of {creatureOne} outside of the cave where the dragon's lair is located. {nameOne}, in a blaze of glory, bravely runs away to the nearby town of {locationOne}.");
        prompt.Add($"It is here that {nameOne} meets {nameTwo}, a {ageOne}-year-old street urchin. The two team up and, using {nameTwo}'s knowledge, deflty sneak into the dragon's lair. Once inside {nameOne} plays a rousing batlledance which motivates {nameTwo} to charge the Dragon Matriarch head-on. {nameTwo} uses a rusty {toolOne} to pierce the scales of the dragon. For {nameTwo}'s efforts, the dragon swallowed {nameTwo} whole. All alone, {nameOne} charged into the line of fire, quite literally as the dragon's mouth was like a blast furnace. {nameOne} was immediately disintegrated, and the Dragon Matriarch took {nameOne}'s only possesion that wasnt burned in the flame for herself: {pocketItem}.");

        return prompt;
    }
}