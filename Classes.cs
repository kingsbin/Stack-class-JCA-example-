using System;
using System.Data;
namespace StackQueueExample
{
    class MyQueue {
        bool isEmpty;
        bool isFull;
        int maxSize;
        string[] queue;
        int front;
        int rear;

        public bool IsEmpty {get {return isEmpty;}}
        public bool IsFull {get {return isFull;}}  

        public MyQueue(int m){
            maxSize=m;
            queue=new string[maxSize];
            front=-1;
            rear=-1;
            isEmpty=true;
            isFull=false;
        }  

        public void EnQueue(string item) {
            if (isEmpty){
                front=0;
                isEmpty=false;
                rear=0;
            } else {
                rear++;
            }
            queue[rear] = item;

        }

        public string DeQueue(){
            string rval= queue[front];
            front++;
            return rval;
        }

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
                rval= "Er'ror - Stack Underflow";
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
