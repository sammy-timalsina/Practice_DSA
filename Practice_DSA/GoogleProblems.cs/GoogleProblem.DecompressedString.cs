using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.GoogleProblems.cs
{
    public partial class GoogleProblem
    {
        public string getDecompressedString(string compressedString)
        {


            //stack of integers to store a number from compressed string
            Stack<string> st = new Stack<string>();
            //ascii value for number 0 is 48
            // subtract compressed string number char with 48 to get int numbers
            for(int i = 0; i < compressedString.Length; i++)
            {
                //check the character of compressedString
                char c = compressedString[i]; 
                //if number
                 if(c >= '0' && c <= '9')
                {
                    //find the number
                    char curr = '[';
                    int ind = i;
                    string num = string.Empty;
                    while(compressedString[ind] != curr)
                    {
                        num=num+compressedString[ind];
                        ind++;
                    }
                    st.Push(num);
                    i = ind-1;
                }
                //if letters
                else if(c >= 'a' && c <= 'z')
                {
                    //find the string
                    char curr = ']';
                    int ind = i;
                    string str = string.Empty;
                    if (ind == compressedString.Length - 1)
                    {
                        //last index
                        str = str + compressedString[ind];
                        ind++;
                    }
                    else
                    {
                        while (compressedString[ind] != curr)
                        {
                            str = str+compressedString[ind];
                            ind++;
                        }
                    }

                    st.Push(str);
                    i = ind-1;
                }
                //if '['
                else if(c=='[')
                {
                    st.Push(compressedString[i].ToString());
                }
                //if']]
                else if(c == ']')
                {
                    string poppedStr = st.Pop();
                    string str = string.Empty;
                    while(!(poppedStr[0] >= '0' && poppedStr[0] <= '9'))
                    {
                        if (poppedStr == '['.ToString())
                        {
                            poppedStr = st.Pop();
                            continue;
                        }
                        else if (poppedStr[0] >= 'a' && poppedStr[0] <= 'z')
                        {
                           
                            str = poppedStr + str;
                            poppedStr = st.Pop();
                        }
                        else
                        {
                            poppedStr = st.Pop();
                        }
                    }
                    int lastNum = Convert.ToInt32(poppedStr)-1;
                    string tempStr = string.Empty;
                    while(lastNum >= 0)
                    {
                        tempStr = tempStr + str;
                        lastNum--;
                    }
                    st.Push(tempStr);
                }

            }
            if(st.Count == 1)
            {
                return st.Pop();
            }
            else if(st.Count == 0)
            {
                return "";
            }
            else
            {
                int k = st.Count-1;
                string ansStr = string.Empty;
                while(k>=0)
                {
                    ansStr = st.Pop() + ansStr;
                    k--;
                }
                return ansStr;
            }
        }
    }
}
