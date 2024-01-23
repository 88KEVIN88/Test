using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public abstract class Component
    {
        public string Text { get; set; }
        public List<Component> Children { get; } = new List<Component>();

        protected Component(string text)
        {
            Text = text;
        }

        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual Component GetChild(int index)
        {
            throw new NotImplementedException();
        }

        public abstract int GetScore();
        public override string ToString() => Text;
        public abstract bool EvaluateAnswer(string answer);


    }
}
