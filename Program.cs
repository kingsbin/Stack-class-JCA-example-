using System;
using System.Data;
namespace StackQueueExample
{

    class Program
    {
        static void Main(string[] args)
        {
            
            MyStack mystack=new MyStack(10);
            mystack.PrintStack();
            mystack.Push("item 1");
            mystack.Push("item 2");
            mystack.Push("item 3");
            mystack.PrintStack();
            Console.WriteLine($"{mystack.Pop()}");
            mystack.PrintStack();
            Console.WriteLine($"{mystack.Pop()}");
            mystack.PrintStack();
            Console.WriteLine($"{mystack.Pop()}");
            mystack.PrintStack();
            Console.WriteLine($"{mystack.Pop()}");
            mystack.Push("item 1");
            mystack.Push("item 2");
            mystack.PrintStack();
            Console.WriteLine($"{mystack.Peek()}");
            mystack.PrintStack();

        }
        }
}
