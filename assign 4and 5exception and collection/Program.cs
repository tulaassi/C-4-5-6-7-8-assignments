using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace stacks
{
    class MyStack
    {
        private int[] ele;
        private int top;
        private int max;

        public MyStack(int size)
        {
            ele = new int[size];
            top = -1;
            max = size;
        }
        public void push(int item)
        {
            try
            {
                ele[++top] = item;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public int pop()
        {
            Console.WriteLine("popped element is :" + ele[top]);
            return ele[top--];
        }
        public void printstack()
        {
            if (top == -1)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("item[" + (i + 1) + "] :" + ele[i]);
                }
            }
        }
    }

    class program
    {
        static void main()
        {
            StackException se = new StackException();
            se.Method();
            Console.ReadLine();
        }
    }
    class StackException
    {
        public void Method()
        {
            MyStack s = new MyStack(5);
            s.push(10);
            s.push(20);
            s.push(30);
            s.push(40);
            s.push(50);
            Console.WriteLine("item are:");
            s.printstack();
            s.pop();
            s.push(50);
            s.push(60);
        }
    }
}
