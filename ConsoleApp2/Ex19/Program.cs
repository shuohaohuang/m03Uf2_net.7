/*Author Shuohao Huang
 * Date 6/12/23
 * Resume Implementa un programa que demani un nombre romà i retorni el seu valor enter.
 */

using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace ConsoleApp8
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string Msg = "Insert a Roman numeral",
                         ArabicMsg = "The numeral you have written is {0}",
                         InvalidNum = "Wrong letter was inserted";

            string insert;
            Console.WriteLine(Msg);
            insert = Console.ReadLine().ToUpper();
            if (RomanToArabic(insert) == 0)// roman nums 0 no exists
            {
                Console.WriteLine(InvalidNum);
            }
            else
            {
                Console.WriteLine(ArabicMsg, RomanToArabic(insert));
            }

        }
        static int RomanToArabic(string romanNumbers)
        {
            char[] RomanNum = RomanConvertTo(romanNumbers);
            int[] arabicNum = RomanConvertTo(RomanNum);
            bool correctNum = CorrectRomanNumRule(arabicNum);
            int result = 0;

            if (correctNum)
            {
                
                
                for (int i = 0; i < arabicNum.Length; i++)
                {
                    for (int j = i + 1; j == i + 1 && correctNum; j++)
                    {
                        if (j < arabicNum.Length)
                        {
                            if (arabicNum[i] >= arabicNum[j])
                            {


                                result += arabicNum[i];
                                if (i == arabicNum.Length - 2) result += arabicNum[j];
                            }
                            else
                            {
                                correctNum = RomanNumOperationRule(arabicNum[i], arabicNum[j]);

                                if (!correctNum) return 0;
                                result += arabicNum[j] - arabicNum[i];
                            }
                        }   
                    }
                    if (i == 0 && result == 0) result += arabicNum[i];
                }
                return result;
            }
            return 0; 
        }
        static char[] RomanConvertTo(string romanNumbers)
        {
            
            char[] letters = romanNumbers.ToCharArray();
            return letters; 
        }
        static int[] RomanConvertTo(char[] letters)
        {
            int[] arbic = new int[letters.Length];
            int[] wrong = new int[letters.Length];
            for (int i = 0; i < letters.Length; i++)
            {
                switch (letters[i])
                {
                    case 'I':
                        arbic[i] = 1;
                        break;
                    case 'V':
                        arbic[i] = 5;
                        break;
                    case 'X':
                        arbic[i] = 10;
                        break;
                    case 'L':
                        arbic[i] = 50;
                        break;
                    case 'C':
                        arbic[i] = 100;
                        break;
                    case 'D':
                        arbic[i] = 500;
                        break;
                    case 'M':
                        arbic[i] = 1000;
                        break;
                     default :
                        return wrong;
                }
            }
            return arbic;
        }

        public static bool RomanNumOperationRule(int firstNum, int secondNum)
        {
            return secondNum<=firstNum*10 && secondNum>=firstNum;
        }

        public static bool CorrectRomanNumRule(int[] RomanNums)
        {
            //Check how many times the same letter appears consecutively; allow a maximum of 3 times, and return false if it occurs four or more times in a row.
            int sameNum = 1;
            int max = 3;
            for (int i = 0; i < RomanNums.Length; i++)// MIII, length=3, index [0,1,2]. i starts at 0.
            {
                for (int j=i+1; j != RomanNums.Length;j++ )//MIII, lenght=3, index[0,1,2], 
                {
                    if (RomanNums[i] == RomanNums[j])
                    {
                        if (!CorrectRomanNumRule(RomanNums, j)) return false;    
                        sameNum++;
                    }
                    else
                    {
                        sameNum = 1;
                    }
                    if (!(sameNum<=max) ) return false;
                }
                sameNum = 1;
            }
            return true;
        }

        public static bool CorrectRomanNumRule(int[]RomanNums, int iterator)
        {
            if (iterator + 1 < RomanNums.Length)
            {
                return RomanNums[iterator] >= RomanNums[iterator+1];
            }
            return true;
        }
    }
}
