using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 55 Algo
            /*
            Console.WriteLine(test(4, 5, 7));
            Console.WriteLine(test(7, 4, 12));
            Console.WriteLine(test(10, 10, 12));
            Console.WriteLine(test(12, 12, 18));
            */
            // Exercise 56 Algo
            /*
            Console.WriteLine(test(4, 5, 7));
            Console.WriteLine(test(7, 4, 12));
            Console.WriteLine(test(10, 13, 12));
            Console.WriteLine(test(13, 12, 18));
            */
            // Exercise 57 Algo
            /*
            Console.WriteLine(test(4, 5, 7));
            Console.WriteLine(test(7, 4, 12));
            Console.WriteLine(test(10, 13, 12));
            Console.WriteLine(test(17, 12, 18));
            */
            // Exercise 58 Algo
            /*
            Console.WriteLine(test(4, 5));
            Console.WriteLine(test(7, 12));
            Console.WriteLine(test(10, 13));
            Console.WriteLine(test(17, 33));
            */
            // Exercise 59 Algo
            /*
            Console.WriteLine(test(4, 5, 6));
            Console.WriteLine(test(7, 12, 13));
            Console.WriteLine(test(-1, 0, 1));
            */
            // Exercise 60 Algo
            /*
            Console.WriteLine(test("Hi", "Hello"));
            Console.WriteLine(test("whats", "app"));
            */
            // Exercise 61 Algo
            /*
            Console.WriteLine(test("[[]]", "Hello"));
            Console.WriteLine(test("(())", "Hi"));
            */
            // Exercise 62 Algo
            /*
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("Hi"));
            */
            // Exercise 63 Algo
            /*
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("Hi"));
            Console.WriteLine(test("H"));
            Console.WriteLine(test(" "));
            */
            // Exercise 64 Algo
            /*
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("Hi"));
            */
            // Exercise 65 Algo
            /*
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("Hi"));
            Console.WriteLine(test("Python"));
            */
            // Exercise 66 Algo
            /*
            Console.WriteLine(test("Hello", "Hi"));
            Console.WriteLine(test("JS", "Python"));
            */
            // Exercise 67 Algo
            /*
            Console.WriteLine(test("Hello", "Hi"));
            Console.WriteLine(test("JS", "Python"));
            */
            // Exercise 68 Algo
            /*
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("JS"));
            */
            // Exercise 69 Algo
            /*
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("JS"));
            */
            // Exercise 70 Algo
            /*
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("JS"));
            Console.WriteLine(test(""));
            */
            // Exercise 71 Algo
            /*
            Console.WriteLine(test("Hell"));
            Console.WriteLine(test("JS"));
            */
            // Exercise 72 Algo
            /*
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("on"));
            Console.WriteLine(test("o"));
            */
            // Exercise 73 Algo
            /*
            Console.WriteLine(test("Hello", 1));
            Console.WriteLine(test("Python", 2));
            Console.WriteLine(test("on", 1));
            Console.WriteLine(test("o", 1));
            */
            // Exercise 74 Algo
            /*
            Console.WriteLine(test("Hello", 1));
            Console.WriteLine(test("Python", 2));
            Console.WriteLine(test("on", 1));
            */
            // Exercise 75 Algo
            /*
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("abc"));
            */
            // Exercise 76 Algo
            /*
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("a"));
            Console.WriteLine(test(""));
            */
            // Exercise 77 Algo
            /*
            Console.WriteLine(test("Hello", "Hi"));
            Console.WriteLine(test("Python", "PHP"));
            Console.WriteLine(test("JS", "JS"));
            Console.WriteLine(test("Csharp", ""));
            */
            // Exercise 78 Algo
            /*
            Console.WriteLine(test("abc", "cat"));
            Console.WriteLine(test("python", "php"));
            Console.WriteLine(test("php", "php"));
            */
            // Exercise 88 Algo 
            /*
            Console.WriteLine(test(new[] { 10, 20, 40, 50 }));
            Console.WriteLine(test(new[] { 5, 20, 40, 10 }));
            Console.WriteLine(test(new[] { 10, 20, 40, 10 }));
            Console.WriteLine(test(new[] { 12, 24, 35, 55 }));
            */
            // Exercise 89 Algo 
            /*
            Console.WriteLine(test(new[] { 10, 20, 40, 50 }));
            Console.WriteLine(test(new[] { 10, 20, 40, 10 }));
            Console.WriteLine(test(new[] { 12, 24, 35, 55 }));
            */
            // Exercise 90 Algo 
            /*
            Console.WriteLine(test(new[] { 10, 20, 40, 50 }, new[] { 10, 20, 40, 50 }));
            Console.WriteLine(test(new[] { 10, 20, 40, 50 }, new[] { 10, 20, 40, 5 }));
            Console.WriteLine(test(new[] { 10, 20, 40, 50 }, new[] { 1, 20, 40, 5 } ));
            */
            // Exercise 91 Algo
            /*
            Console.WriteLine(test(new[] { 10, 20, 30, 40, 50 }));
            Console.WriteLine(test(new[] { 10, 20, -30, -40, 50 }));
            */
            // Exercise 141 Algo
            /*
            List<int> mylist = test(new List<int>(new int[] { 1, 2, 3, 4 }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
            */
            // Exercise 142 Algo
            /*
            List<int> mylist = test(new List<int>(new int[] { 1, 2, 3, 4 }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
            */
            // Exercise 143 Algo
            /*
            List<string> mylist = test(new List<string>(new string[] { "1", "2", "3", "4" }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
            */
            // Exercise 144 Algo
            /*
            List<string> mylist = test(new List<string>(new string[] { "1", "2", "3", "4" }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
            */
            // Exercise 146 Algo
            /*
            List<int> mylist = test(new List<int>(new int[] { 10, 22, 35, 41 }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
            */
            // Exercise 147 Algo
            /*
            List<string> mylist = test(new List<string>(new string[] { "Abc", "cdef", "js", "php" }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
            */
            // Exercise 148 Algo
            /*
            List<string> mylist = test(new List<string>(new string[] { "abc", "cdaef", "js", "php" }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
            */
            // Exercise 149 Algo
            /*
            List<int> mylist = test(new List<int>(new int[] { 0, -2, 1, 2, 3, 5, 4, 7, 8 }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
            */
            // Exercise 150 Algo
            List<int> mylist = test(new List<int>(new int[] { 10, 22, 35, 47, 53, 67 }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.ReadLine();
        }
        // Exercise 55 Algo
        /*
        public static int test(int x, int y, int z)
        {
            if (x == y)
            {
                return z;
            }
            else if(y == z)
            {
                return x;
            }
            else if (x == z)
            {
                return y;
            }
            else
            {
                return x + y + z;
            }
        }
        */
        // Exercise 56 Algo
        /*
        public static int test(int x, int y, int z)
        {
            if (x == 13) return 0;
            if (y == 13) return x;
            if (z == 13) return x + y;
            return x + y + z;
        }
        */
        // Exercise 57 Algo
        /*
        public static int test(int x, int y, int z)
        {
            return Program.fix_num(x) + Program.fix_num(y) + Program.fix_num(z);
        }
        private static int fix_num(int n)
        {
            return (n < 13 && n > 9) || (n > 17 && n < 21) ? 0 : n;
        }
        */
        // Exercise 58 Algo
        /*
        public static int test(int x, int y)
        {
            
            if (x > 13 && y > 13) return 0;
            if (x <= 13 && y > 13) return x;
            if (y <= 13 && x > 13) return y;
                    return x > y ? x : y;
        }
        */
        // Exercise 59 Algo
        /*
        public static bool test(int x, int y, int z)
        {

            if (z-y == y-x) return true;
            return false;
        }
        */
        // Exercise 60 Algo
        /*
        public static string test(string x, string y)
        {

            return x + y + y + x;
        }
        */
        // Exercise 61 Algo
        /*
        public static string test(string x, string y)
        {

            return x.Substring(0,2) + y + x.Substring(2,2);
        }
        */
        // Exercise 62 Algo
        /*
        public static string test(string x)
        {
            if(x.Length >= 2)
            {
                return x.Substring(x.Length - 2, 2)+
                    x.Substring(x.Length - 2, 2)+
                    x.Substring(x.Length - 2, 2);
            } else
            {
                return x;
            }
        }
        */
        // Exercise 63 Algo
        /*
        public static string test(string x)
        {
            if (x.Length >= 2)
            {
                return x.Substring(0, 2);
            }
            else
            {
                return x;
            }
        }
        */
        // Exercise 64 Algo
        /*
        public static string test(string x)
        {
            return x.Substring(0, x.Length / 2);
        }
        */
        // Exercise 65 Algo
        /*
        public static string test(string x)
        {
            return x.Substring(1, x.Length-2);
        }
        */
        // Exercise 66 Algo
        /*
        public static string test(string x, string y)
        {
            return (x.Length > y.Length) ? x + y + x : y + x + y;
        }
        */
        // Exercise 67 Algo
        /*
        public static string test(string x, string y)
        {
            return (x.Length>1 && y.Length>1) ? 
                x.Substring(1,x.Length-1) + y.Substring(1, y.Length - 1) 
                : x+y;
        }
        */
        // Exercise 68 Algo
        /*
        public static string test(string x)
        {
            return (x.Length > 1)?
                x.Substring(2, x.Length - 2) + x.Substring(0,2)
                : x;
        }
        */
        // Exercise 69 Algo
        /*
        public static string test(string x)
        {
            return (x.Length > 1) ?
                x.Substring(x.Length - 2, 2) + x.Substring(0, x.Length - 2)
                : x;
        }
        */
        // Exercise 70 Algo
        /*
        public static string test(string x)
        {
            return (x.Length > 2) ?
                x.Substring(1, x.Length-2) 
                : "";
        }
        */
        // Exercise 71 Algo
        /*
        public static string test(string x)
        {
            return (x.Length > 2) ?
                x.Substring(x.Length/2-1, 2)
                : x;
        }
        */
        // Exercise 72 Algo
        /*
        public static bool test(string x)
        {
            return (x.Length > 1) ?
                x.Substring(x.Length-2, 2)=="on"
                : false;
        }
        */
        // Exercise 73 Algo
        /*
        public static string test(string x, int y)
        {
            return x.Substring(0, y) + x.Substring(x.Length - y, y);
        }
        */
        // Exercise 74 Algo
        /*
        public static string test(string x, int y)
        {
            return (x.Length>2) ? x.Substring(y, 2) : x;
        }
        */
        // Exercise 75 Algo
        /*
        public static string test(string x)
        {
            return (x.Length > 3) ? x.Substring((x.Length-3)/2, 3) : x;
        }
        */
        // Exercise 76 Algo
        /*
        public static string test(string x)
        {
            if (x.Length >= 2)
            {
                x = x.Substring(0, 2);
            }
            else if (x.Length > 0)
            {
                x = x.Substring(0, 1) + "#";
            }
            else
            {
                x = "##";
            }

            return x;
        }
        */
        // Exercise 77 Algo
        /*
        public static string test(string x, string y)
        {
            string lastChars = String.Empty;

            if (x.Length > 0)
            {
                lastChars += x.Substring(0, 1);
            }
            else
            {
                lastChars += "#";
            }

            if (y.Length > 0)
            {
                lastChars += y.Substring(y.Length - 1);
            }
            else
            {
                lastChars += "#";
            }

            return lastChars;
        }
        */
        // Exercise 78 Algo
        /*
        public static string test(string x, string y)
        {
            string lastChars = String.Empty;
            if (y.Length < 1)
            {
                return x;
            }
            if(x.Length < 1)
            {
                return y;
            }

            return !x.EndsWith(y.Substring(0, 1)) ? x+ y : x + y.Substring(1);
        }
        */
        // Exercise 88 Algo
        /*
        public static bool test(int[] nums)
        {
            return nums[0] == 10 || nums[nums.Length - 1] == 10;
        }
        */
        // Exercise 89 Algo
        /*
        public static bool test(int[] nums)
        {
            return nums.Length > 0 && nums[0] == nums[nums.Length - 1];
        }
        */
        // Exercise 90 Algo
        /*
        public static bool test(int[] nums, int[] nums2)
        {
            return (nums.Length > 0 && nums2.Length > 0) 
                && (nums[0] == nums2[0]) || (nums[nums.Length - 1] == nums2[nums2.Length - 1]);
        }
        */
        // Exercise 91 Algo
        /*
        public static int test(int[] nums)
        {
            int sum = 0;
            for(int i=0; i< nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
                }
        */
        // Exercise 141 Algo
        /*
        public static List<int> test(List<int> nums)
        {
            IEnumerable<int> doubled = nums.Select(x => x *= 3);
            return doubled.ToList<int>();
        }
        */
        // Exercise 142 Algo
        /*
        public static List<int> test(List<int> nums)
        {
            IEnumerable<int> doubled = nums.Select(x => x *x*x);
            return doubled.ToList<int>();
        }
        */
        // Exercise 143 Algo
        /*
        public static List<string> test(List<string> nums)
        {
            IEnumerable<string> doubled = nums.Select(x => "#" + x + "#");
            return doubled.ToList<string>();
        }
        */
        // Exercise 144 Algo
        /*
        public static List<string> test(List<string> nums)
        {
            IEnumerable<string> doubled = nums.Select(x => x+x+x+x);
            return doubled.ToList<string>();
        }
        */
        // Exercise 146 Algo
        /*
        public static List<int> test(List<int> nums)
        {
            IEnumerable<int> doubled = nums.Select(x => x % 10);
            return doubled.ToList<int>();
        }
        */
        // Exercise 147 Algo
        /*
        public static List<string> test(List<string> str)
        {
            IEnumerable<string> s = str.Select(x => x.ToUpper());
            return s.ToList();
        }
        */
        // Exercise 148 Algo
        /*
        public static List<string> test(List<string> str)
        {
            return str.Select(x => x.Replace("a", "")).ToList();
        }
        */
        // Exercise 149 Algo
        /*
        public static List<int> test(List<int> nums)
        {
            return nums.Where(n => n < 4).ToList();
        }
        */
        // Exercise 150 Algo
        public static List<int> test(List<int> nums)
        {
            return nums.Where(n => n % 10 < 7).ToList();
        }
    }




}


