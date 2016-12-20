namespace ScoreAI.Scorer
{
    using ScoreAI.Qualifier;

    public class LinkedScorer : IContextualScorer
    {
        private readonly IQualifier qualifier;

        public LinkedScorer(IQualifier qualifier)
        {
            this.qualifier = qualifier;
        }

        public float Score()
        {
            return this.qualifier.Score();
        }
    }
}
