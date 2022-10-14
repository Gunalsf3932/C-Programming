using System;

namespace ArrayListDS
{
    public partial class ArrayList
    {
        public void Insert(int index,dynamic data)
        {
           _count+=1;
            dynamic[] Array3=new dynamic[_capacity+1];

            for(int i=0;i<_count;i++)
            {
                if(i<index)
                {
                    Array3[i]=Array[i];
                }
                else if(index==i)
                {
                    Array3[index]=data;
                }
                else
                {
                    Array3[i]=Array[i-1];
                }
            }
            Array=Array3;
            
        }

        public void RemoveAt(int index)
        {
            for (int i=0;i<_count;i++)
            {
                if(i>=index)
                {
                    Array[i]=Array[i+1];
                }
               
            }
             _count--;

        }

        public void Remove(dynamic data)
        {
            int count=0;
            for(int i=0;i<_count;i++)
            {
                if(Array[i].Equals(data))
                {
                    if(count==0)
                    {
                    Array[i]=Array[i+1];
                    count=1;
                    }
                }
                else if(count==1)
                {
                    Array[i]=Array[i+1];
                }
            }
            _count--;
        }
        
        


        

        
    }
}
