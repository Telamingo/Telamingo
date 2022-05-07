using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.QuestionAggregate
{
    public class Answer : Entity
    {
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
        public string TextEn { get; set; }
        public string TextFa { get; set; }
    }
}
