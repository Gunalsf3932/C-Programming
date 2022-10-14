using System;

namespace DictionaryDS
{
    public partial class Dictionary<TKey,TValue>
    {
        public KeyValue<TKey,TValue> [] Array {get; set;}
        private int _count;
        private int _capacity;
        public int Count{get{return _count;}} 
        public int Capacity {get{return _capacity;}}  

        public TValue this [TKey key]
        {
            get 
            {
                TValue output = default(TValue);
                int index=0;
                bool temp=LinearSearch(key,out index);
                if(temp)
                {
                    output=Array[index].Value;
                }
                else{
                    System.Console.WriteLine("Invalid Key");
                }
                 return output;
            }
            set{
                int index=0;
                bool temp=LinearSearch(key,out index );
                if(temp)
                {
                    Array[index].Value=value;
                }
                else{
                     System.Console.WriteLine("Invalid Key");
                }
            }
           
        }
    
    public Dictionary()
    {
        _count=0;
        _capacity=4;
        Array =new KeyValue<TKey,TValue>[_capacity];

    }
    public Dictionary(int size)
    {
        _count=0;
        _capacity=size;
        Array=new KeyValue<TKey,TValue>[_capacity];
    }
    public void Add(TKey key , TValue value)
    {
        if(_count==_capacity)
        {
            GrowSize();
        }

        bool temp=LinearSearch(key,out int index);
        if(temp==true)
        {
            System.Console.WriteLine("Duplicate key");
        }
        if(temp==false)
        {
            KeyValue<TKey,TValue> entry=new KeyValue<TKey, TValue>();
            entry.Key=key;
            entry.Value=value;
            Array[_count]=entry;
            _count++;
        }
    }
    public void GrowSize()
    {
        _capacity=_capacity*2;
        KeyValue<TKey,TValue> [] Array1=new KeyValue<TKey,TValue>[_capacity];
        for(int i=0;i<_count;i++)
        {
            Array1[i]=Array[i];
        }
        Array=Array1;
    }
      public bool LinearSearch(TKey key, out int index)
    {
        bool temp=false;
        index=0;
        for(int i=0;i<_count;i++)
        {
        if(key.Equals(Array[i].Key))
        {
            index=i;
           temp=true;
           break;
        }
        else{
            temp=false;
        }
        }
        return temp;
       
    }
    

    }
  
}
