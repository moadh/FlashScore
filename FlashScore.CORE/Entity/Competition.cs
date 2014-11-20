using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlashScore.CORE.Entity
{
    public class Competition
    {
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
    }
}
