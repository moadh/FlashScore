using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashScore.CORE.Entity
{
   public class MatchEventType
    {
        public int Id
        {
            get;
            set;
        }

        public int Entry
        {
            get;
            set;
        }
        public int Substitution
        {
            get;
            set;
        }
        public int YellowCard
        {
            get;
            set;
        }
        public int RedCard
        {
            get;
            set;
        }
        public int Foul
        {
            get;
            set;
        }
        public int FreeKick
        {
            get;
            set;
        }
        public int CornerKick
        {
            get;
            set;
        }
        public int PenaltyKick
        {
            get;
            set;
        }
        public int Goal
        {
            get;
            set;
        }
    }
}
