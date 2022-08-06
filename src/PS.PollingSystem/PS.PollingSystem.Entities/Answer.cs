using PS.PollingSystem.Entities.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.PollingSystem.Entities
{
    [DebuggerDisplay("{Title} {Votes} {Percents}")]
    public class Answer : Identity
    {


        public string Title { get; init; }
        public int Votes { get; set; }
        public double Percents { get; set; }      

        public Answer(Guid id, string title)
        {
            Id = id;
            Title = title;
        }

        public void SetPercents(int totalVotes)
        {
            if(totalVotes > 0)
            {
                Percents = Votes * 100 / totalVotes;
            }
        }

        public override string ToString()
        {
            return $"{Title} - {Votes} ({Percents:F}%)";
        }

    }
}
