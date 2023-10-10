using System;
using System.Data;
namespace StackQueueExample
{
    class MyQueue {

    }
    class MyStack{
        bool isEmpty;
        bool isFull;
        int maxSize;
        string[] stack;
        int head;
        public bool IsEmpty{get {return isEmpty;} }
        public bool IsFull{get {return isFull;} }

        public MyStack(int ms) {
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

    
}
