using System;

namespace DictionaryDS
{
    public partial class Dictionary<TKey,TValue>
    {
        public bool ContainsKey(TKey key)
        {
           int index=0;
           bool temp=LinearSearch(key,out index);
           return true;
        }
   
        public bool ContainsValue(TValue value)
        {
            bool temp = false;
            for(int i =0;i<_count;i++)
            {
                if(value.Equals(Array[i].Value))
                {
                    temp = true;
                    break;
                }
            }
            return temp;
        }      

       
        public KeyValue<TKey,TValue> ElementAt(int index)
        {
            KeyValue<TKey,TValue> output=null;
            for(int i=0;i<_count;i++)
            {
                if(index.Equals(Array[i]))
                {
                    output=Array[i];
                    break;
                }
            }
            return output;
        }
        public void Remove(TKey key)
        {
            int temp=0;
             for(int i=0;i<_count;i++)
            {
                if(Array[i].Equals(key))
                {
                    if(temp==0)
                    {
                    Array[i]=Array[i+1];
                    temp=1;
                    }
                }
                if(temp==1)
                {
                    Array[i]=Array[i+1];
                }
        }

   
    }
      

    }

}
