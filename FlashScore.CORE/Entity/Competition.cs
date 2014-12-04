using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlashScore.CORE.Entity
{
    public class Competition
    {

        public Competition()
        {
            Rounds = new List<Round>();
        }
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public IList<Group> Groups
        {
            get;
            set;
        }
        public IList<Round> Rounds
        {
            get;
            set;
        }

        public int Year { get; set; }
    }
}
