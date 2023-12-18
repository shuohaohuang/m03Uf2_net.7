/* Author Shuohao Huang
 * Date 18/12/23
 */
using System;
using UsualUtils;
namespace NaturalNums
{
    public class NaturalNum
    {
        static void Main()
        {
            const string GetNumMsg = "Insert a natual number";

            Console.WriteLine(GetNumMsg);
            int userNum = (int)Utils.GetNum();
            Console.WriteLine(ValidateNatural(userNum));
        }

        public static bool ValidateNatural(int num)
        {
            return num%1==0 && num>0;
        }
    }
}