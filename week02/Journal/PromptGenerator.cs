public class PromptGenerator
{
    List<string> _prompt = new List<string>();

    string first_prompt = "What did you do today?";
    string second_prompt = "What did you dream last night?";
    string third_prompt = "What did you eat yesterday at lunch?";

    string fourth_prompt = "What did you eat yesterday at lunch?";

    
    public PromptGenerator()
    {
        _prompt.Add(first_prompt);
        _prompt.Add(second_prompt);
        _prompt.Add(third_prompt);
        _prompt.Add(fourth_prompt);
    }

    public string GetRandomPrompt()
    {
        Random randomPrompt=new Random();
        int index = randomPrompt.Next(0,3);
        return _prompt[index];
    }

    


}