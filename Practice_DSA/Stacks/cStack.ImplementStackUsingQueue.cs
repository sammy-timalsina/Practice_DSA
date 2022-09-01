using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Stacks
{
    public partial class cStack
    {
        Queue<int> qu1 = new Queue<int>();
        private Queue<int> qu2;
        public void Push(int x)
        {
           if(Empty())
            {
                qu1.Enqueue(x);
            }
           else
            {
                while(qu1.Count > 0)
                {
                    qu2.Enqueue(qu1.Dequeue());
                }
                qu1.Enqueue(x);
                while(qu2.Count > 0)
                {
                    qu1.Enqueue(qu2.Dequeue());
                }
            }

        }

        public int Pop()
        {
          if(!Empty())
            {
                return qu1.Dequeue();
            }
          else
            {
                return -111;
            }
        }

        public int Top()
        {
            if(!Empty())
            {
                return qu1.Peek();
            }
            else
            {
                return -111;
            }
        }

        public bool Empty()
        {
            if(qu1.Count ==0)
            {
                return true;
            }
            return false;
        }
    }
}
