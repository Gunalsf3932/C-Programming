using System;

namespace QueueDS
{
    public partial class Queue<Type>
    {
        private Type [] Array{get; set;}
        private int _count;
        private int _head;
        private int _capacity;
        private int _tail;
        public int Count{get{return _count;}}

        public Queue()
        {
            _count=0;
            _head=0;
            _capacity=4;
            _tail=0;
            Array =new Type[_capacity];
        }
        public Queue(int size)
        {
            _count=0;
            _head=0;
            _capacity=size;
            _tail=0;
            Array =new Type[_capacity];
        }
        public void EnQueue(Type data)
        {
            if(_tail==_capacity)
            {
                Growsize();
            }
            Array[_tail]=data;
            _count++;
            _tail++;
        }
        public void Growsize()
        {
            _capacity=_capacity*2;

            Type[] Array1 =new Type[_capacity];
            for(int i=0;i<_tail;i++)
            {
                Array1[i]=Array[i];
            }
            Array=Array1;
        }
        public Type DeQueue()
        {
            Type value=default (Type);
            if(_head>_tail)
            {
                System.Console.WriteLine("Queue Empty");
            }
            else{
                value=Array[_head];
                _head++;
                _count--;
            }
            return value;

        }
        public Type Peek()
        { Type value=default (Type);
            if(_head>_tail)
            {
                System.Console.WriteLine("Queue Empty");
            }
            else{
                value=Array[_head];
            }
            return value;
            }
        public bool Contains(Type data)
        {
            bool value=false;
            for(int i=0;i<_tail;i++)
            {
                if(Array[i].Equals(data))
                {
                    value=true;
                }
            }
            return value;
        
        }
    }
}

