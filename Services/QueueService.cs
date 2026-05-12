using interview_question_005.Models;

namespace interview_question_005.Services;

public class QueueService
{
    private readonly QueueState _state = new();

    public string GetCurrentQueue()
    {
        return _state.CurrentQueue;
    }

    public string GenerateNextQueue()
    {
        var current = _state.CurrentQueue;

        char letter = current[0];
        int number = int.Parse(current[1].ToString());

        if (number < 9)
        {
            number++;
        }
        else
        {
            number = 0;

            if (letter < 'Z')
            {
                letter++;
            }
            else
            {
                letter = 'A';
            }
        }

        _state.CurrentQueue = $"{letter}{number}";
        //        Console.WriteLine("letter ==> ", letter);
        return _state.CurrentQueue;
    }

    public string ResetQueue()
    {
        _state.CurrentQueue = "A0";

        return _state.CurrentQueue;
    }
}
