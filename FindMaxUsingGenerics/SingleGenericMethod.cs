using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
    
        public class SingleGenericMethod<uType> where uType : IComparable
        {
            uType E;
            uType F;
            uType G;
            public SingleGenericMethod(uType E, uType F, uType G)  
            {
                this.E = E;
                this.F = F;
                this.G = G;
            }
            public void Compare()
            {
                if (E.CompareTo(F) > 0 && E.CompareTo(G) > 0 )
                {
                    Console.WriteLine("The Max is E and the value is : {0}", E);
                }
                else if (F.CompareTo(G) > 0 && F.CompareTo(E) > 0 )
                {
                    Console.WriteLine("The Max is F and the value is : {0}", F);
                }
                else if (G.CompareTo(E) > 0 && G.CompareTo(F) > 0 )
                {
                    Console.WriteLine("The Max is G and the value is : {0}", G);
                }
                
            }
        }
 }

