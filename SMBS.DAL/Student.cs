using System.Collections.Generic;

namespace SMBS.DAL
{
    public class Student
    {
        public int StudentId { get; set; }
        
        public string Name { get; set; }

        public string Class { get; set; }

        public virtual IList<Examination> Examinations { get; set; }
    }
}
