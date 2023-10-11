using System;
using System.Data;
namespace StackQueueExample
{

    class Program
    {
        static void TestStack(){
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
        
        static void TestQueue(){
            MyQueue myqueue=new MyQueue(4);
            Console.WriteLine($"Dequeued {myqueue.DeQueue()}");
            Console.WriteLine($"Error {myqueue.Error} Msg {myqueue.Msg}");
            myqueue.PrintQueue();
            myqueue.EnQueue("One");
            myqueue.EnQueue("Two");
            myqueue.EnQueue("Three");
            myqueue.EnQueue("Four");
            myqueue.EnQueue("Five");
            Console.WriteLine($"Error {myqueue.Error} Msg {myqueue.Msg}");
            myqueue.PrintQueue();
            Console.WriteLine($"Dequeued {myqueue.DeQueue()}");
            Console.WriteLine($"Error {myqueue.Error} Msg {myqueue.Msg}");
            myqueue.EnQueue("Six");
            Console.WriteLine($"Error {myqueue.Error} Msg {myqueue.Msg}");
            myqueue.PrintQueue();
            myqueue.EnQueue("Seven");
            Console.WriteLine($"Error {myqueue.Error} Msg {myqueue.Msg}");
            myqueue.PrintQueue();
            Console.WriteLine($"Dequeued {myqueue.DeQueue()}");
            Console.WriteLine($"Error {myqueue.Error} Msg {myqueue.Msg}");
            myqueue.PrintQueue();
            
        }

        static void Main(string[] args)
        {
            TestQueue();
            TestStack();
            

        }
        }
}
