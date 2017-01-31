using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoi
{
    class TowerOfHanoi
    {
        public TowerOfHanoi()
        {
            Console.WriteLine("Enter the number of disks to use.");
            Console.WriteLine("Less than 5 is good.");

            string input = Console.ReadLine();
            int diskNumber = Int32.Parse(input);

            moveDisk(diskNumber, 'A', 'B', 'C');
            Console.WriteLine(Environment.NewLine + "Towers of Hanoi has been solved using the above steps ^" + Environment.NewLine + "Press any key to exit...");
            Console.ReadKey();
        }

        private void moveDisk(int n, char src, char aux, char dest)
        {
            // if this is true, we have hit the base case. 
            // all printing is done in the base case.
            if(n == 1) // base case
            {
                Console.WriteLine("Move disk from Tower {0} to tower {1}", src, dest);
            }
            else
            {
                // make a recursive call to move n-1 disks from the src peg, to the aux peg
                moveDisk(n - 1, src, dest, aux); // m1

                // make a recursive call to move the 1 (bottom) disk from the src to the destination
                moveDisk(1, src, aux, dest); // m2

                // make a recursive call to move n-1 disks from the aux peg to the destination
                moveDisk(n-1, aux, src, dest); // m3
            }
        }
    }
}
