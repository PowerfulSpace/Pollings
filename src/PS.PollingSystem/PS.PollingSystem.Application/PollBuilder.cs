using PS.PollingSystem.Entities;

public class PollBuilder
{

    private readonly string _questionStrng;

    private readonly List<Answer> _items = new List<Answer>();


    public PollBuilder(string questionStrng)
    {
        _questionStrng = questionStrng;
    }


    public PollBuilder AddAnswer(Guid id, string title)
    {
        _items.Add(new Answer(id, title));
        return this;
    }

    public Poll Build()
    {
        var poll = new Poll(_questionStrng, _items);
        return poll;
    }

    public PollResults GetResults(Poll poll)
    {
        return new PollResults(poll);
    }


}