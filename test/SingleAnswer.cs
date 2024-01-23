using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class SingleAnswerQuestion : Component
    {
        private string CorrectAnswer { get; }

        public SingleAnswerQuestion(string text, string correctAnswer) : base(text)
        {
            CorrectAnswer = correctAnswer;
        }

        public override int GetScore()
        {
           
            return 0;
        }

        public override bool EvaluateAnswer(string answer)
        {
            return answer.Trim().Equals(CorrectAnswer.Trim(), StringComparison.OrdinalIgnoreCase);
        }
    }
}
