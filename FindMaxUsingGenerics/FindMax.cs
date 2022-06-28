using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FindMaxUsingGenerics
{
    public class Find<uType> where uType : IComparable
    {
        public void Compare(uType X, uType Y, uType Z)
        {
            if (X.CompareTo(Y) > 0 && X.CompareTo(Z) > 0 )
            {
                Console.WriteLine("The Max is X and the value is : {0}", X);
            }
            else if (Y.CompareTo(X) > 0 && Y.CompareTo(Z) > 0) 
            {
                Console.WriteLine("The Max is Y and the value is : {0}", Y);
            }
            else if (Z.CompareTo(X) > 0 && Z.CompareTo(Y) > 0) 
            {
                Console.WriteLine("The Max is Z and the value is : {0}", Z);
            }
           
        }
    }
}