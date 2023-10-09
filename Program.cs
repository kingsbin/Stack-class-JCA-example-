using System;
using System.Data;
namespace StackExample
{
    class myStack{
        bool isEmpty;
        bool isFull;
        int maxSize;
        string[] stack;
        int head;
        public bool IsEmpty{get {return isEmpty;} }
        public bool IsFull{get {return isFull;} }

        public myStack(int ms) {
            maxSize=ms;
            stack = new string[maxSize];
            isEmpty=true;
            isFull=false;
            head=-1;
        }

        public string Pop(){
            string rval;
            if (isEmpty) {
                rval= "Error - Stack Underflow";
            } else {
                rval=stack[head];
                stack[head]="";
                head --;
                if (head == -1) {
                    isEmpty=true;
                }
            }
            return rval;
        }

        public string Peek(){
            string rval;
            if (isEmpty) {
                rval= "Error - Stack Empty";
            } else {
                rval=stack[head];
            }
            return rval;
        }

        public string Push(string newItem){
            string rval;
            if (isFull) {
                rval="Error - Stack Overflow";
            } else {
                head++;
                stack[head]=newItem;
                if (head==maxSize) {
                    isFull=true;
                }
                isEmpty=false;
                rval=$"{newItem} added";
            }    
            return rval;    
        }

        public void PrintStack(){
            Console.WriteLine("--Stack-------");
            if (isEmpty) {
                Console.WriteLine("Empty");
            } else {
                for (int i=head; i>=0; i--) {
                    Console.WriteLine($"{i}:{stack[i]}");
                }
            }
            Console.WriteLine("-------------");
            return;
        }


    } 

    class Program
    {
        static void Main(string[] args)
        {
            
            myStack mystack=new myStack(10);
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
