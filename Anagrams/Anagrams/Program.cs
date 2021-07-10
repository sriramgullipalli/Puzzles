using System;
using System.Collections.Generic;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String1 :");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter String2 :");
            string str2 = Console.ReadLine();

            List<int> result = Anagram(str1, str2);
            Console.Write("Output : ");
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
        }

        private static List<int> Anagram(string str1, string str2)
        {
            List<int> myList = new List<int>();
            for (int i = 0; i < str1.Length; i++)
            {
                bool response = isAnagram(i, str1, str2);
                if (response)
                {
                    myList.Add(i);
                }
            }
            return myList;
        }

        private static bool isAnagram(int index, string str1, string str2)
        {
            bool res = false;
            if (index != str1.Length)
            {
                if (str2.Contains(str1[index]))
                {
                    string strRemoved = DeleteCharFromString(index, str1, str2);
                    if (!string.IsNullOrEmpty(strRemoved))
                    {
                        res = isAnagram(index + 1, str1, strRemoved);
                    }
                    else
                    {
                        res = true;
                    }
                }
            }
            return res;
        }

        private static string DeleteCharFromString(int num, string str1, string str2)
        {
            for (int j = 0; j < str2.Length; j++)
            {
                if (str2[j] == str1[num])
                {
                    if (j == str2.Length - 1)
                    {
                        str2 = str2.Remove(j);
                    }
                    else
                    {
                        str2 = str2.Remove(j, 1);
                    }
                }
            }
            return str2;
        }
    }
}
