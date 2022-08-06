using PS.PollingSystem.Entities.Base;
using System.Diagnostics;

namespace PS.PollingSystem.Entities
{
    [DebuggerDisplay("{QuestionText}")]
    public  class Poll : Identity
    {
        public string QuestionText { get; set; } = null!;
        public List<Answer>? Answers { get; set; }


        public Poll(string questionText, List<Answer> answers) : this(questionText)
        {
            Answers = answers;
        }

        public Poll(string questionText)
        {
            QuestionText = questionText;
        }


        public void VoteTo(Guid id, int value = 1)
        {
            var item = Answers?.SingleOrDefault(x => x.Id == id);

            if(item == null) { return; }

            item.Votes += value;

            var totalVotes = Answers?.Sum(x => x.Votes) ?? 0;

            Answers?.ForEach(x => x.SetPercents(totalVotes));

        }

    }
}
