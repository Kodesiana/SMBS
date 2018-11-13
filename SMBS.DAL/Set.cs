using System;
using System.Collections.Generic;

namespace SMBS.DAL
{
    public class Set
    {
        public int SetId { get; set; }

        public string Title { get; set; }      

        public virtual IList<Question> Questions { get; set; }
    }
}
