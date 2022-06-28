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
            if (X.CompareTo(Y) > 0 && X.CompareTo(Z) > 0)
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
            Console.WriteLine("*******************************************************************");
        }
        public void CompareFloat(double A, double B, double C)
        {
            
                if (A.CompareTo(B) > 0 && A.CompareTo(C) > 0)
                {
                    Console.WriteLine("The Max is A and the value is : {0}", A);
                }
                else if (B.CompareTo(C) > 0 && B.CompareTo(A) > 0)
                {
                    Console.WriteLine("The Max is B and the value is : {0}", B);
                }
                else if (C.CompareTo(A) > 0 && C.CompareTo(B) > 0)
                {
                    Console.WriteLine("The Max is C and the value is : {0}", C);
                }
            Console.WriteLine("*******************************************************************");
        }
        public void CompareString(string M, string N, string O)
        {
            if (M.CompareTo(N) > 0 && M.CompareTo(O) > 0)
            {
                Console.WriteLine("The Max is M and the value is : {0}", M);
            }
            else if (N.CompareTo(O) > 0 && N.CompareTo(M) > 0)
            {
                Console.WriteLine("The Max is N and the value is : {0}", N);
            }
            else if (O.CompareTo(M) > 0 && O.CompareTo(N) > 0)
            {
                Console.WriteLine("The Max is O and the value is : {0}", O);
            }
            Console.WriteLine("*******************************************************************");
        }

    }
}
