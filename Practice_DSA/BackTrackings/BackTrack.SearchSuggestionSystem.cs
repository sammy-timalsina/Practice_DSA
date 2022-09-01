using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BackTrackings
{
    public partial class BackTrack
    {
        public void testCaseForSearchSuggestionSystem()
        {
            //You are given an array of strings products and a string searchWord
            //Design a system that suggests at most three product names from products after each character of searchWord is typed.
            // Suggested products should have common prefix with searchWord.
            // If there are more than three products with a common prefix return the three lexicographically minimums product
            //Return a list of lists of the suggested products after each character of searchWord is typed.


            //Example1

            //Input: products = ["mobile", "mouse", "moneypot", "monitor", "mousepad"], searchWord = "mouse"
            //Output:[
            //["mobile","moneypot","monitor"],
            //["mobile","moneypot","monitor"],
            //["mouse","mousepad"],
            //["mouse","mousepad"],
            //["mouse","mousepad"]
            //]
            //Explanation: products sorted lexicographically = ["mobile", "moneypot", "monitor", "mouse", "mousepad"]
            //After typing m and mo all products match and we show user["mobile", "moneypot", "monitor"]
            //After typing mou, mous and mouse the system suggests["mouse", "mousepad"]

        }
        private IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            //first of all put the products in lexicographical order
            return null;
        }
    }
}
