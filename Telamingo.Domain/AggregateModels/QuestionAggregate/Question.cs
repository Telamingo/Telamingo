using System.Collections.Generic;
using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.QuestionAggregate
{
    public class Question : Entity
    {
        public string ContextEn { get; set; }
        public string ContextFa { get; set; }
        public int AnswerType { get; set; }
        public int CategoryId { get; set; }
        public bool MultiSelect { get; set; }

        public IReadOnlyCollection<Answer> Answers => _Answer;
        private readonly List<Answer> _Answer;

    }
}
