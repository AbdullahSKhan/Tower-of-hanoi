    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Diagnostics;
    using System.Threading.Tasks;

    namespace hahahaha
    {
        class Abdullah
        {
        
            int m_numdiscs;
            public Abdullah()
            {
                numdiscs = 0;
            }
            public Abdullah(int newval)
            {
                numdiscs = newval;
            }
            public int numdiscs
         
            {
            
                get
                {
                    return m_numdiscs;
                }
                set
                {
                    if (value > 0)
                        m_numdiscs = value;
                }
            }
            public void movetower(int n, int beg, int aux, int end)
            {
                if (n > 0)
                {
                    movetower(n - 1, beg, end, aux);
                    Console.WriteLine("Move disk {0} from tower {1} to tower {2}", n, beg, aux);
                    movetower(n - 1, end, aux, beg);
                }
            }
        }
        class TowersOfHanoiApp
        {
            public static int Main()
            {
                var watch = new System.Diagnostics.Stopwatch();
                var elapsedMs = watch.ElapsedMilliseconds;

                watch.Start();
                Abdullah T = new Abdullah();
                string cnumdiscs;
                Console.Write("Enter the number of discs: ");
                cnumdiscs = Console.ReadLine();
                T.numdiscs = Convert.ToInt32(cnumdiscs);
                T.movetower(T.numdiscs, 1, 3, 2);
                Console.ReadLine();
                Console.WriteLine("Time elapsed: {0}", watch.Elapsed);
                Console.ReadLine();
                watch.Stop();
                return 0;
            }
        }
    }
