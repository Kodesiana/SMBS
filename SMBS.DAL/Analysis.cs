namespace SMBS.DAL
{
    public class Analysis
    {
        public int AnalysisId { get; set; }

        public Question Question { get; set; }

        public AnswerKey Answer { get; set; }

        public bool IsTrue { get; set; }
    }
}
