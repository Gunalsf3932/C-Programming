using System;
using System.Collections;
namespace GroceryShop
{
    public partial class List<Type> : IEnumerable ,IEnumerator
    {
         int i;
         public IEnumerator GetEnumerator()
        {
            i=-1;
        return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            if(i<Count-1)
            {
                ++i;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            i=-1;
        }
        public object Current {
            get{ return Array[i]; }

        }

    }
}
