using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodawaniePoRzymsku
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Program calculating sum of two roman numerals, not greater than M".ToUpper());

            string nb1 = null;
            string nb2 = null;
            bool both_nbs_entered = false;
            int whichOne = both_nbs_entered == false ? 1 : 2;

            do
            {
                Console.WriteLine("\nInput {0} roman numeral, not greater than M: ", whichOne);
                string usersNumber = Console.ReadLine().ToUpper();

                if (Roman2Arabic(usersNumber) > 1000)
                {
                    Console.WriteLine("\t\tNot greater than M!");
                }
                else
                {
                    Console.WriteLine("\t\t\t{0}", usersNumber);
                    if (nb1 is null == false)
                    {
                        nb2 = usersNumber;
                        both_nbs_entered = true;
                    }
                    else
                    {
                        nb1 = usersNumber;
                    }
                }
            } while (!both_nbs_entered);

            Console.WriteLine("\n\nNumerals given by you are:\n \n\t{0}\n\t{1}", nb1, nb2);
            Console.WriteLine("\n\nSum of them is:  {0}", Sum(nb1, nb2).ToString());
            Console.WriteLine("\n\nAs Arabic numeral: {0}", Roman2Arabic(Sum(nb1, nb2)));


            ConsoleKey exitExit;
            do
            {
                Console.WriteLine("\n\n\tp r e s s   E  S  C   t o   e x i t ");
                exitExit = Console.ReadKey().Key;
            } while (exitExit != ConsoleKey.Escape);
        }


        /// <summary>
        /// Sums two roman numerics. Converting them to arabic during process. 
        /// </summary>
        /// <param name="nb1">First term of result</param>
        /// <param name="nb2">Second term of result</param>
        /// <returns>Returns sum of both terms.</returns>
        public static string Sum(string nb1, string nb2)
        {
            int result = Roman2Arabic(nb1) + Roman2Arabic(nb2);


            return Arabic2Roman(result);
        }


        /// <summary>
        /// Converts roman numerals to arabic numerals.
        /// </summary>
        /// <param name="romanNumber">Takes roman numeral as parameter.</param>
        /// <returns>Returns arabic numeral.</returns>
        public static int Roman2Arabic(string romanNumber)
        {
            char[] initialCharArrMadeOfRomanNumbers = romanNumber.ToCharArray();
            int[] resultingIntArr = new int[initialCharArrMadeOfRomanNumbers.Length];

            Dictionary<char, int> roman2arab_NumeralsDictionary = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            for (int i = 0; i < initialCharArrMadeOfRomanNumbers.Length; i++)
            {
                if (roman2arab_NumeralsDictionary.TryGetValue(initialCharArrMadeOfRomanNumbers[i], out int value))
                {
                    if (i + 1 != initialCharArrMadeOfRomanNumbers.Length)
                    {
                        if (roman2arab_NumeralsDictionary.TryGetValue(initialCharArrMadeOfRomanNumbers[i + 1], out int nextValue))
                        {
                            resultingIntArr[i] = value < nextValue ? value * (-1) : value;
                        }
                    }
                    else
                    {
                        resultingIntArr[i] = value;
                    }
                }
                else
                {
                    return -1;
                }
            }


            return resultingIntArr.Sum();
        }


        /// <summary>
        /// Converts arabic numerals to roman numerals.
        /// </summary>
        /// <param name="arabicNumeral">Takes arabic numeral as parameter.</param>
        /// <param name="romanNumeral">Second parameter ought to be left empty as by default. It is used in recursive converting process.</param>
        /// <returns>Returns roman numeral.</returns>
        public static string Arabic2Roman(int arabicNumeral, string romanNumeral = "")
        {
            Dictionary<int, string> arabic2romanDictionary = new Dictionary<int, string>
            {
                { 1000, "M" },
                { 900, "CM" },
                { 500, "D" },
                { 400, "CD" },
                { 100, "C" },
                { 90, "XC" },
                { 50, "L" },
                { 40, "XL" },
                { 10, "X" },
                { 9, "IX" },
                { 5, "V" },
                { 4, "IV"},
                { 1, "I" },
                { 0, "" }
            };

            int change;
            foreach (KeyValuePair<int, string> item in arabic2romanDictionary)
            {
                if (arabicNumeral == item.Key)
                {
                    romanNumeral += item.Value;
                    return romanNumeral;
                }
                else
                {
                    if (arabicNumeral - item.Key > -1)
                    {
                        romanNumeral += item.Value;
                        change = item.Key;
                        return Arabic2Roman(arabicNumeral - change, romanNumeral);
                    }
                }
            }


            return romanNumeral;
        }

    } // end of Class 
} // end of Namespace
