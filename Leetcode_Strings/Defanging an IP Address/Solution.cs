using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode_Strings.Defanging_an_IP_Address
{
    class Solution
    {
        public string DefangIPaddr(string address)
        {
            string output = address.Replace(".", "[.]");
            return output;
        }
    }
}
