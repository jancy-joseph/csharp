using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    public static class NumbertoWords
    {
        // A function that prints  
        // given number in words  from geeksfor geeks 
        public static void convert_to_words(char[] num)
        {
            // Get number of digits  
            // in given number  
            int len = num.Length;

            // Base cases  
            if (len == 0)
            {
                Console.WriteLine("empty string");
                return;
            }
            if (len > 4)
            {
                Console.WriteLine("Length more than " +
                                  "4 is not supported");
                return;
            }

            /* The first string is not used,  
               it is to make array indexing simple */
            string[] single_digits = new string[]{ "zero", "one", "two",
                                           "three", "four", "five",
                                           "six", "seven", "eight",
                                           "nine"};

            /* The first string is not used,  
               it is to make array indexing simple */
            string[] two_digits = new string[]{"", "ten", "eleven", "twelve",
                                       "thirteen", "fourteen",
                                       "fifteen", "sixteen", "seventeen",
                                       "eighteen", "nineteen"};

            /* The first two string are not used, 
               they are to make array indexing simple*/
            string[] tens_multiple = new string[]{"", "", "twenty", "thirty",
                                          "forty", "fifty","sixty",
                                          "seventy", "eighty", "ninety"};

            string[] tens_power = new string[] { "hundred", "thousand" };

            /* Used for debugging purpose only */
            Console.Write((new string(num)) + ": ");

            /* For single digit number */
            if (len == 1)
            {
                Console.WriteLine(single_digits[num[0] - '0']);
                return;
            }

            /* Iterate while num  
                is not '\0' */
            int x = 0;
            while (x < num.Length)
            {

                /* Code path for first 2 digits */
                if (len >= 3)
                {
                    if (num[x] - '0' != 0)
                    {
                        Console.Write(single_digits[num[x] - '0'] + " ");
                        Console.Write(tens_power[len - 3] + " ");

                        // here len can be 3 or 4  
                    }
                    --len;
                }

                /* Code path for last 2 digits */
                else
                {
                    /* Need to explicitly handle  
                    10-19. Sum of the two digits  
                    is used as index of "two_digits"  
                    array of strings */
                    if (num[x] - '0' == 1)
                    {
                        int sum = num[x] - '0' +
                                  num[x] - '0';
                        Console.WriteLine(two_digits[sum]);
                        return;
                    }

                    /* Need to explicitely handle 20 */
                    else if (num[x] - '0' == 2 &&
                             num[x + 1] - '0' == 0)
                    {
                        Console.WriteLine("twenty");
                        return;
                    }

                    /* Rest of the two digit  
                    numbers i.e., 21 to 99 */
                    else
                    {
                        int i = (num[x] - '0');
                        if (i > 0)
                            Console.Write(tens_multiple[i] + " ");
                        else
                            Console.Write("");
                        ++x;
                        if (num[x] - '0' != 0)
                            Console.WriteLine(single_digits[num[x] - '0']);
                    }
                }
                ++x;
            }
        }
        public static void convert_twodigits(char[] chr,int firstindex,int secondindex,string[] one_digit,string[] twodigits,string[] no11to19,StringBuilder sb1)
        {
            int i = (int)(chr[firstindex] - '0');
            if(i == 1)
            {
                int j = (int)(chr[secondindex] - '0');
                sb1.Append(no11to19[j]);
               // Console.Write(no11to19[j]);
            }
            else
            {
                sb1.Append(twodigits[i]+" ");
                //Console.Write(twodigits[i]+" ");
                int j = (int)(chr[secondindex] - '0');
                if (j != 0)
                {
                    sb1.Append(one_digit[j]);
                  //  Console.Write(one_digit[j]);
                }
               
            }

        }

        public static void convert_threedigits(char[] str, int firstindex, int secondindex,int thirdindex, string[] single_digit, string[] two_digits, string[] numbers10_19, StringBuilder sb1)
        {

            int i = (int)(str[firstindex] - '0');
            if (i == 0)//eg.010
            {
                convert_twodigits(str, secondindex, thirdindex, single_digit, two_digits, numbers10_19, sb1);
                return;
            }
            else//eg:120
            {
                sb1.Append(single_digit[i] + " hundred ");
                //Console.Write(single_digit[i] + " hundred ");
                convert_twodigits(str, secondindex, thirdindex, single_digit, two_digits, numbers10_19, sb1);
                return;
            }
        }
         //Writing my own function for number to words
        public static void myConvertNoToWords(string s)
        {
            

            if (s.Length == 0)
            {
                Console.WriteLine("Empty string");
                return;
            }
            //convert to character array
            char[] str = s.ToCharArray();
            
            StringBuilder sb = new StringBuilder(45);//after calculating maximum words possible including spaces
            string[] single_digit = new string[10] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            if (s.Length == 1)//eg."1"
            {
                int i = (int)(str[0] - '0');
                sb.Append(single_digit[i]);
                Console.WriteLine(sb.ToString());
                return;
            }

            string[] two_digits = new string[10] { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] numbers10_19 = new string[10] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

            if (s.Length == 2)//eg."22"
            {
                convert_twodigits(str, 0, 1, single_digit,two_digits, numbers10_19,sb);
                Console.WriteLine(sb);
                return;
            }

            if (s.Length == 3)
            {
                convert_threedigits(str, 0, 1, 2, single_digit, two_digits, numbers10_19, sb);
                Console.WriteLine(sb);
                return;
            }
            if(s.Length == 4)
            {
                int i = (int)(str[0] - '0');
                if(i == 0)//eg:0101
                {
                    convert_threedigits(str, 1, 2, 3, single_digit, two_digits, numbers10_19, sb);
                    Console.WriteLine(sb);
                    return;
                }
                else
                {
                    sb.Append(single_digit[i] + " thousand ");
                    //Console.Write(sb);
                    convert_threedigits(str, 1, 2, 3, single_digit, two_digits, numbers10_19, sb);
                    Console.WriteLine(sb);
                    return;
                }
            }

        }

    }
}
