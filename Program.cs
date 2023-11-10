using System;
using System.Data;
namespace StackQueueExample
{

    class Program
    {
        //Tests 1 of stack
        static void TestStack1(){
            MyStack mystack=new MyStack(10);
            Console.WriteLine("TestStack 1");
            Console.WriteLine("------------");
            Console.WriteLine("Should output an empty stack");
            Console.WriteLine("");
            mystack.PrintStack();
            Console.WriteLine("");
            Console.WriteLine("");
            mystack.Push("item 1");
            mystack.Push("item 2");
            mystack.Push("item 3");
            Console.WriteLine("Should output a stack of 3 items with item 3 at top");
            Console.WriteLine("");
            mystack.PrintStack();
        }
        static void TestStack2(){
            MyStack mystack=new MyStack(10);
            Console.WriteLine("TestStack 2");
            Console.WriteLine("------------");
            Console.WriteLine("Should output an empty stack");
            mystack.PrintStack();
            mystack.Push("item 1");
            mystack.Push("item 2");
            mystack.Push("item 3");
            Console.WriteLine("Should output a stack of 3 items with item 3 at top");
            Console.WriteLine("");
            mystack.PrintStack();
            Console.WriteLine("Now pop the top item");
            Console.WriteLine("");
            Console.WriteLine($"pop of top item = {mystack.Pop()}");
            Console.WriteLine("Should output a stack of 2 items with item 2 at top");
            Console.WriteLine("");
            mystack.PrintStack();
        }        
        static void TestStack3(){
            MyStack mystack=new MyStack(10);
            Console.WriteLine("TestStack 3");
            Console.WriteLine("------------");
            Console.WriteLine("Should output an empty stack");
            mystack.PrintStack();
            mystack.Push("item 1");
            mystack.Push("item 2");
            mystack.Push("item 3");
            Console.WriteLine("Should output a stack of 3 items with item 3 at top");
            Console.WriteLine("");
            mystack.PrintStack();
            Console.WriteLine("Will now remove 3 items pushed");
            Console.WriteLine($"Pop 1 ={mystack.Pop()}");
            Console.WriteLine($"Pop 2 ={mystack.Pop()}");
            Console.WriteLine($"Pop 3 ={mystack.Pop()}");
            Console.WriteLine("Will now attempt to pop from empty stack");
            Console.WriteLine("");
            Console.WriteLine($"Pop 4 ={mystack.Pop()}");
            Console.WriteLine($"Message on Stack ={mystack.Msg}");
        }        
        static void TestStack4(){
            MyStack mystack=new MyStack(4);
            Console.WriteLine("TestStack 4");
            Console.WriteLine("------------");
            Console.WriteLine("Stack has been configured with max size of 4");
            Console.WriteLine("Should output an empty stack");
            mystack.PrintStack();
            mystack.Push("item 1");
            mystack.Push("item 2");
            mystack.Push("item 3");
            mystack.Push("item 4");
            Console.WriteLine("Should output a stack of 4 items with item 4 at top");
            Console.WriteLine("");
            mystack.PrintStack();
            Console.WriteLine("Will now attempt to push a 5th item");
            mystack.Push("item 5");
            Console.WriteLine($"Message on Stack ={mystack.Msg}");
            mystack.PrintStack();
        }        
        static void TestStack5(){
            MyStack mystack=new MyStack(10);
            Console.WriteLine("TestStack 5");
            Console.WriteLine("------------");
            Console.WriteLine("Should output an empty stack");
            mystack.PrintStack();
            mystack.Push("item 1");
            mystack.Push("item 2");
            Console.WriteLine("Should output a stack of 2 items with item 2 at top");
            Console.WriteLine("");
            mystack.PrintStack();
            Console.WriteLine("Will now peek at stack");
            Console.WriteLine($"Peek ={mystack.Peek()}");
            Console.WriteLine($"Message on Stack ={mystack.Msg}");
            Console.WriteLine("Should still have a stack of 2 items with item 2 at top");
            Console.WriteLine("");
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
            //TestQueue();
            Console.WriteLine("************   STACK TEST 1   **************");
            Console.WriteLine("");
            TestStack1();
            Console.WriteLine("************   STACK TEST 2   **************");
            Console.WriteLine("");
            TestStack2();            
            Console.WriteLine("************   STACK TEST 3   **************");
            Console.WriteLine("");
            TestStack3();
            Console.WriteLine("************   STACK TEST 4   **************");
            Console.WriteLine("");
            TestStack4();            
            Console.WriteLine("************   STACK TEST 5   **************");
            Console.WriteLine("");
            TestStack5();            

        }
        }
}
