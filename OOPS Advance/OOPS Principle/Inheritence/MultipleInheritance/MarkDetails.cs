using System;

namespace MultipleInheritance
{
    public interface IMarkDetails
    {
        int Physics { get; set; }  //Property declaration only allowed
        int Chemistry{get; set;}
        int Maths { get; set; }
        int Total { get; set; }
        double Average { get; set; }
        void GetMark(int physics,int chemistry,int maths);

        void Calculate();   //Method declaration only allowed
        void ShowMark();

        
        
    }
}
