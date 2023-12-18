/*Author Shuohao Huang
 * Date 6/12/23
 * Resume Implementa un programa que demani un nombre romà i retorni el seu valor enter.
 */

namespace Roman
{
    public class RomanIntoArabic
    {
        static void Main(string[] args)
        {
            const string Msg = "Insert a Roman numeral";

            string insert;
            Console.WriteLine(Msg);
            insert = Console.ReadLine().ToUpper();
            WriteArabicNumber(insert);

        }

        public static void WriteArabicNumber(string romanNumber)
        {
            const string ArabicMsg = "The numeral you have written is {0}",
              InvalidNumMsg = "Wrong roman number was inserted";
            const int Zero = 0;
            int arabicNum = RomanToArabic(romanNumber);
            if (arabicNum == Zero) // in roman nums 0 no exists
            {
                Console.WriteLine(InvalidNumMsg);
            }
            else
            {
                Console.WriteLine(ArabicMsg, arabicNum);
            }
        }

        static int RomanToArabic(string romanNumbers)
        {
            const int WrongValue = 0; // in roman nums 0 no exists

            char[] RomanNum = RomanConvertTo(romanNumbers);
            int[] arabicNum = RomanConvertTo(RomanNum);
            int result = WrongValue;

            if (CorrectRomanNumRule(arabicNum))
            {
                for (int i = 0; i < arabicNum.Length; i++)
                {
                    int nextNum = i + 1;
                    if (nextNum < arabicNum.Length) //avoid ArrayIndexOutOfBoundsException
                    {
                        if (arabicNum[i] >= arabicNum[nextNum])
                        {
                            result += arabicNum[i];
                            if (nextNum == arabicNum.Length - 1) result += arabicNum[nextNum];
                            //if the next number is the last one, it adds it
                        }
                        else
                        {
                            if (!RomanNumOperationRule(arabicNum[i], arabicNum[nextNum])) return WrongValue;
                            result += arabicNum[nextNum] - arabicNum[i];
                        }
                    }
                    if (i == WrongValue && result == WrongValue) result += arabicNum[i];
                    // in case the num only has one digit
                }
                return result;
            }
            return WrongValue;
        }
        static char[] RomanConvertTo(string romanNumbers) //probably useless method 
        {
            //returns an array of chars
            return romanNumbers.ToCharArray();
        }

        static int[] RomanConvertTo(char[] letters)
        {
            int[] arbic = new int[letters.Length];
            int[] wrong = new int[letters.Length]; // a void int char
            for (int i = 0; i < letters.Length; i++) //if the letter is correct, put the corresponding value into the array
                                                     //else return a void int array
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
                    default:
                        return wrong;
                }
            }
            return arbic; //if all are correct return a filled int array
        }

        public static bool RomanNumOperationRule(int subtractingNum, int SubtractedNum)
        {
            // I,X,C can only subtract from numbers that are two scales away from them
            // I can subtract from V and X
            return SubtractedNum <= subtractingNum * 10 && SubtractedNum >= subtractingNum;
        }

        public static bool CorrectRomanNumRule(int[] RomanNums)
        {
            //Check how many times the same letter appears consecutively; allow a maximum of 3 times, and return false if it occurs four or more times in a row.
            int sameNum = 1;
            int max = 3;
            for (int i = 0; i < RomanNums.Length; i++) // MIII, length=3, index [0,1,2]. i starts at 0.
            {
                for (int j = i + 1; j != RomanNums.Length; j++) //MIII, length=3, index[0,1,2], 
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
                    if (!(sameNum <= max)) return false; // if has 4 same int in a row returns false.
                }
                sameNum = 1; //reset to one for each int in RomanNums
            }
            return true; //if all are correct returns true;
        }

        public static bool CorrectRomanNumRule(int[] RomanNums, int iterator)
        {
            //this method checks multiple smaller values before a greater one, like IIX

            if (iterator + 1 < RomanNums.Length)
            {
                return RomanNums[iterator] >= RomanNums[iterator + 1];
            }
            return true; //if it is the last digit, it returns true by default.
        }
    }
}