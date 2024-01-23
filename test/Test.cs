using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
   
    public class Test : Component
    {
        public Test(string text) : base(text) { }

        public override void Add(Component component)
        {
            Children.Add(component);
        }

        public override void Remove(Component component)
        {
            Children.Remove(component);
        }

        public override Component GetChild(int index)
        {
            return Children[index];
        }

        public override int GetScore()
        {
            return Children.Sum(component => component.GetScore());
        }

        public override bool EvaluateAnswer(string answer)
        {
            
            throw new NotImplementedException();
        }
    }

}
