using System;
using System.Collections.Generic;

namespace SMBS.DAL
{
    public class Examination
    {
        public int ExaminationId { get; set; }

        public DateTime Date { get; set; }

        public Student Student { get; set; }

        public Set Set { get; set; }

        public float Score { get; set; }
        
        public virtual IList<Analysis> Analysis { get; set; }
    }
}
