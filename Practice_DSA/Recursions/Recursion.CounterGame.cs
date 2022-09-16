using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Recursions
{
    public partial class Recursion
    {
        //Louise and Richard have developed a numbers game.They pick a number and check to see if it is a power of.If it is, they divide it by 2.
        //If not, they reduce it by the next lower number which is a power of.Whoever reduces the number to wins the game. Louise always starts.

        //Given an initial value, determine who wins the game.

        //Example

        //It's Louise's turn first.She determines that  is not a power of . The next lower power of  is , so she subtracts that from and passes to Richard.
        //is a power of , so Richard divides it by and passes to Louise.Likewise,  is a power so she divides it by and reaches.She wins the game.

        //Update If they initially set counter to , Richard wins. Louise cannot make a move so she loses.

        //Function Description

        //Complete the counterGame function in the editor below.

        //counterGame has the following parameter(s):

        //int n: the initial game counter value
        //Returns

        //string: either Richard or Louise
        //Input Format

        //The first line contains an integer, the number of testcases.
        //Each of the next  lines contains an integer, the initial value for each game.

        //Constraints

        //Sample Input 0
        public string counterGame(long n)
        {
            n = 6;
            //have state representation 
            //if state is odd Louise wins
            //if state is even Richard wins
            long curr = 2;
            int state = 0;
            if (n == 1)
                return "Richard";
            while(true)
            {
                bool res = checkIfItsPowerOf2(n, ref curr);
                state++;
                if (n == 1)
                    break;
                if (!res)
                {
                    n = n - curr;
                }
                else
                {
                    n = n / 2;
                }
                curr = 2;
            }
            if (state % 2 == 1)
                return "Richard";
            return "Louise";
        }
        public bool checkIfItsPowerOf2(long n,ref long curr)
        {
            if(curr == n)
            {
                curr = n;
                return true;
            }
            else if(curr > n)
            {
                curr = curr >> 1;
                return false;
            }
            curr = curr << 1;
            return checkIfItsPowerOf2(n,ref curr);
        }

    }
}
