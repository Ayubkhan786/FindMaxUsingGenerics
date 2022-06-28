using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
        public class Exp<uType> where uType : IComparable
        {
            uType[] A;    
            public Exp(params uType[] arr)   
            {
                this.A = arr;
            }
            public void sorting()
            {
                Array.Sort(this.A);
            }
            public uType Compare()
            {
                return A[A.Length - 1];
            }
            public void Display()
            {
                foreach (var uType in A)
                {
                    Console.WriteLine("The data is :" + uType);
                }
            }
        }
 }

