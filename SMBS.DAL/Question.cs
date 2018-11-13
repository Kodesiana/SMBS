using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SMBS.DAL
{
    public class Question
    {
        public int QuestionId { get; set; }
        
        public byte[] Content { get; set; }

        [Required]
        public AnswerKey Answer { get; set; }

        public virtual IList<Set> Sets { get; set; }
    }
}
