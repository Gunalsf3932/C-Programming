using System;

namespace StudentAdmission
{
    public partial class List<Type>
    {
        public void Insert(int index,Type data)
        {
            Type[] Array3=new Type[_capacity+1];
            for(int i=0;i<_count+1;i++)
            {
                if(i<index)
                {
                    Array3[i]=Array[i];
                }
                else if(index==i)
                {
                    Array3[i]=data;
                }
                else if(i>index)
                {
                    Array3[i]=Array[i-1];
                }
            }
            Array=Array3;
            _count++;
        }

        public void RemoveAt(int index)
        {
            for (int i=0;i<_count;i++)
            {
                if(i>=index)
                {
                    Array[i]=Array[i+1];
                }
                _count--;
            }

        }

        public void Remove(Type data)
        {
            int Count=0;
            for(int i=0;i<_count;i++)
            {
                if(data.Equals(Array[i]))
                {
                    Count=i;
                }
            }
            for(var i=0;i<_count;i++)
            {
                if(i>Count)
                {
                    Array[i]=Array[i+1];
                }
                _count--;
            }
        }
        
        


        

        
    }
}
