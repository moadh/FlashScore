using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashScore.CORE.Entity
{
   public class Round
    {
        public int Id
        {
            get;
            set;
        }

        public int Number
        {
            get;
            set;
        }
        public DateTime Date
        {
            get;
            set;
        }
        public IList<Match> Matchs { get; set; }
    }
}
