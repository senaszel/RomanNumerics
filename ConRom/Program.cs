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
            Console.WriteLine("Dodawanie dwoch liczb nie wiekszych niz 1000 po rzymsku:".ToUpper());

            string nb1 = null;
            string nb2 = null;
            bool two_nbs = false;
            int ktora = two_nbs == false ? 1 : 2;
            do
            {
                Console.WriteLine("\nPodaj {0} liczbe, nie wieksza niz 1000: ", ktora);
                int liczbaUzytkownika = Convert.ToInt32(Console.ReadLine());

                if (liczbaUzytkownika > 1000)
                {
                    Console.WriteLine("\t\tMiala byc nie wieksza niz 1000!");
                }
                else
                {
                    string cyfraRzymska = Convert2Roman(liczbaUzytkownika);
                    Console.WriteLine("\t\t\t{0}", cyfraRzymska);
                    if (nb1 is null == false)
                    {
                        nb2 = cyfraRzymska;
                        two_nbs = true;
                    }
                    else
                    {
                        nb1 = cyfraRzymska;
                    }

                }


            } while (!two_nbs);

            Console.WriteLine("\n\n");
            Console.WriteLine("Podane liczby to:\n \n\t{0}\n\t{1}", nb1, nb2);


            Console.WriteLine("\n\n Wynikiem sumowania tych liczb jest:  {0}", Sum(nb1, nb2).ToString());
            Console.WriteLine("\n po naszemu: {0}", Roman2Arab(Sum(nb1, nb2)));
            ConsoleKey exitExit;
            do
            {
                Console.WriteLine("\n\n\tp r e s s   E  S  C   t o   e x i t ");
                exitExit = Console.ReadKey().Key;
            } while (exitExit != ConsoleKey.Escape);
        }

        public static string Sum(string nb1, string nb2)
        {
            int result = Roman2Arab(nb1) + Roman2Arab(nb2);
            return Convert2Roman(result);
        }

        public static int Roman2Arab(string romanNumber)
        {
            char[] arr = romanNumber.ToCharArray();
            int[] arabArr = new int[] { 1, 5, 10, 50, 100, 500, 1000 };
            char[] transitionArr = new char[] { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            int[] resultingArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < transitionArr.Length; j++)
                {
                    if (arr[i] == transitionArr[j])
                    {
                        resultingArr[i] = arabArr[j];
                    }
                }
            }

            Console.WriteLine("\n\ndla liczby: {0}", romanNumber);
            for (int i = 0; i < resultingArr.Length; i++)
            {
                Console.WriteLine(resultingArr[i]);
            }
            for (int i = 0; i < resultingArr.Length; i++)
            {
                if (i + 1 != resultingArr.Length)
                {
                    if (resultingArr[i] < resultingArr[i + 1])
                    {
                        resultingArr[i] = resultingArr[i] * (-1);
                    }
                }
            }
            Console.WriteLine("\n\nPo zastosowaniu algorytmu przeliczajacego dla liczby: {0}", romanNumber);
            for (int i = 0; i < resultingArr.Length; i++)
            {
                Console.WriteLine(resultingArr[i]);
            }



            return resultingArr.Sum();
        }

        public static string Convert2Roman(int cyfraArabska,
                                     string cyfraRzymska = "")
        {
            if (cyfraArabska == 0)
            {
                if (cyfraRzymska == "")
                {

                    return "0";
                }
                else
                {
                    return cyfraRzymska;
                }

            }

            if (cyfraArabska == 1000)
            {

                cyfraRzymska += "M";
                return cyfraRzymska;
            }
            if (cyfraArabska > 1000)
            {
                cyfraRzymska += "M";
                return Convert2Roman(cyfraArabska - 1000, cyfraRzymska);
            }
            else
            {

                if (cyfraArabska == 900)
                {

                    cyfraRzymska += "CM";
                    return cyfraRzymska;
                }

                if (cyfraArabska > 900)
                {
                    cyfraRzymska += "CM";
                    return Convert2Roman(cyfraArabska - 900, cyfraRzymska);
                }
                else
                {
                    if (cyfraArabska == 500)
                    {
                        cyfraRzymska += "D";
                        return cyfraRzymska;
                    }

                    if (cyfraArabska > 500)
                    {
                        cyfraRzymska += "D";
                        return Convert2Roman(cyfraArabska - 500, cyfraRzymska);
                    }
                    else
                    {
                        if (cyfraArabska == 400)
                        {
                            cyfraRzymska += "CD";
                            return cyfraRzymska;
                        }

                        if (cyfraArabska > 400)
                        {
                            cyfraRzymska += "CD";
                            return Convert2Roman(cyfraArabska - 400, cyfraRzymska);
                        }
                        else
                        {
                            if (cyfraArabska == 100)
                            {
                                cyfraRzymska += "C";
                                return cyfraRzymska;
                            }
                            if (cyfraArabska > 100)
                            {
                                cyfraRzymska += "C";
                                return Convert2Roman(cyfraArabska - 100, cyfraRzymska);
                            }
                            else
                            {
                                if (cyfraArabska == 90)
                                {
                                    cyfraRzymska += "XC";
                                    return cyfraRzymska;
                                }

                                if (cyfraArabska > 90)
                                {
                                    cyfraRzymska += "XC";
                                    return Convert2Roman(cyfraArabska - 90, cyfraRzymska);
                                }
                                else
                                {
                                    if (cyfraArabska == 50)
                                    {
                                        cyfraRzymska += "L";
                                        return cyfraRzymska;
                                    }
                                    if (cyfraArabska > 50)
                                    {
                                        cyfraRzymska += "L";
                                        return Convert2Roman(cyfraArabska - 50, cyfraRzymska);
                                    }
                                    else
                                    {
                                        if (cyfraArabska == 40)
                                        {
                                            cyfraRzymska += "XL";
                                            return cyfraRzymska;
                                        }

                                        if (cyfraArabska > 40)
                                        {
                                            cyfraRzymska += "XL";
                                            return Convert2Roman(cyfraArabska - 40, cyfraRzymska);
                                        }
                                        else
                                        {
                                            if (cyfraArabska == 10)
                                            {
                                                cyfraRzymska += "X";
                                                return cyfraRzymska;
                                            }

                                            if (cyfraArabska > 10)
                                            {
                                                cyfraRzymska += "X";
                                                return Convert2Roman(cyfraArabska - 10, cyfraRzymska);
                                            }
                                            else
                                            {
                                                if (cyfraArabska == 9)
                                                {
                                                    cyfraRzymska += "IX";
                                                    return cyfraRzymska;
                                                }

                                                if (cyfraArabska == 5)
                                                {
                                                    cyfraRzymska += "V";
                                                    return cyfraRzymska;
                                                }

                                                if (cyfraArabska > 5)
                                                {
                                                    cyfraRzymska += "V";
                                                    return Convert2Roman(cyfraArabska - 5, cyfraRzymska);
                                                }

                                                if (cyfraArabska == 4)
                                                {
                                                    cyfraRzymska += "IV";
                                                    return Convert2Roman(cyfraArabska - 4, cyfraRzymska);
                                                }

                                                else
                                                {
                                                    cyfraRzymska += "I";
                                                    return Convert2Roman(cyfraArabska - 1, cyfraRzymska);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        } 
    } // end of Class Program
} // end of namespace
