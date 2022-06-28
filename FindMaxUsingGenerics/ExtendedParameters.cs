using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
        public class Exp<uType> where uType : IComparable
        {
            uType[] A;    //variable
            public Exp(params uType[] arr)   //constructor
            {
                this.A = arr;
            }
            public void sort()
            {
                Array.Sort(this.A);
            }
            public uType Comparison()
            {
                return A[A.Length - 1];
            }
            public void Show()
            {
                foreach (var uType in A)
                {
                    Console.WriteLine("The data is :" + uType);
                }
            }
        }
 }

