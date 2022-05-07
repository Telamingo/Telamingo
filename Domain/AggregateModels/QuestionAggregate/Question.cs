using Domain.SeedWork;
using System.Collections.Generic;

namespace Domain.AggregateModels.QuestionAggregate
{
    public class Question: Entity
    {
        public string ContextEn { get; set; }
        public string ContextFa { get; set; }
        public int AnswerType { get; set; }
        public bool MultiSelect { get; set; }

        public IReadOnlyCollection<Answer> Answers => _Answer;
        private readonly List<Answer> _Answer;

    }
}
