﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlashScore.CORE.Entity
{
    public class Group
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
        public IList<Team> Teams { get; set; }
    }
}
