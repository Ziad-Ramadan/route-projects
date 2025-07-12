using System;
namespace routeassignmentone
{
    #region q6 partone
    //class ziad
    //{
    //    public string name;
    //}
    #endregion
    class Program
    {


        static void Main(string[] args)
        {
            #region q1
            //Console.Write("enter number ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine(number);
            #endregion
            #region q2
            //string input = Console.ReadLine();
            //int number = int.Parse(input);
            //Console.WriteLine(number);
            //it gives me an error bec it is not correct formate at execution time
            #endregion
            #region q3
            //float first = 8.65899999999999f;
            //float second = 5.2222222222222f;
            //Console.WriteLine(first + second);
            // what will happen?
            // nothing it works without any error or even a warning
            #endregion
            #region q4
            //Console.Write("enter the word ");
            //string theword = Console.ReadLine();
            //Console.Write("enter the substring ");
            //string substring = Console.ReadLine();
            //if (theword.Contains(substring))
            //{
            //    Console.WriteLine(substring);
            //}
            //else 
            //{
            //    Console.WriteLine("not found");
            //}
            #endregion
            //----------------------------------------------------------------
            #region q4 anther approach
            //if u want to substring function
            //i ve to speacify starting index and how many charcherts will take
            //Console.Write("enter the word ");
            //string theword = Console.ReadLine();
            //Console.WriteLine(theword.Substring(2,5));
            #endregion
            #region q5
            //int one = 1;
            //int two = one;
            //Console.WriteLine(two);
            //two = 123;
            //Console.WriteLine(two);
            // we aren't handel a scope problem so it work in the first one the value 1 and the second is 123 as we reassign the value to the new one
            // its call by value
            #endregion
            #region q6 parttwo
            //ziad ziadisone = new ziad();
            //ziadisone.name = "ziad ramadan";
            //ziad ziadisalwaysone = ziadisone;
            //Console.WriteLine(ziadisalwaysone.name);
            //ziadisalwaysone.name = "ziad ramadan assignment done";
            //Console.WriteLine(ziadisalwaysone.name);
            //-------
            // in the first time i thought that u want me to use & like call the place in memory but after i search it not accepted and the meaning in c# is diffrent its a objects here
            #endregion
            #region q7
            //string one = Console.ReadLine();
            //string two = Console.ReadLine();
            //string three = one + two;
            //Console.WriteLine(three);
            #endregion
            #region q8
            //Console.WriteLine("enter the principal");
            //double principal = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("enter the rate");
            //double rate = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("enter the time");
            //double time = Convert.ToDouble(Console.ReadLine());
            //double interset = (principal * rate * time) / 100;
            //Console.WriteLine(interset);
            #endregion
            #region q9
            //Console.WriteLine("enter the hight");
            //double height = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("enter the weight");
            //double weight = Convert.ToDouble(Console.ReadLine());
            //double bmi = (weight) / (height *height);
            //Console.WriteLine(bmi);
            #endregion
            #region q10
            //Console.WriteLine("enter temperature");
            //int temp = int.Parse(Console.ReadLine());
            //string result = temp < 10 ? "just cold" : temp > 30 ? "just hot" : "just good";
            //Console.WriteLine(result);
            #endregion
            #region q11
            //Console.Write("enter day");
            //int day = int.Parse(Console.ReadLine());
            //Console.Write("enter month");
            //int month = int.Parse(Console.ReadLine());
            //Console.Write("enter year");
            //int year = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{day},{month},{year}");
            //Console.WriteLine($"{day}-{month}-{year}");
            //Console.WriteLine($"{day}/{month}/{year}");
            #endregion
            #region q12
            //Console.WriteLine("enter number");
            //int num = int.Parse(Console.ReadLine());
            //string result = (num % 3 == 0 && num % 4 == 0) ? "yes" : "no";
            //Console.WriteLine(result);
            #endregion
            #region q13
            //Console.WriteLine("enter number");
            //int num = int.Parse(Console.ReadLine());
            //string result = (num < 0) ? "negative" : "positive";
            //Console.WriteLine(result);
            #endregion
            #region q14
            //Console.WriteLine("enter the number");
            //string[] number = Console.ReadLine().Split();
            //int a = int.Parse(number[0]);
            //int b = int.Parse(number[1]);
            //int c = int.Parse(number[2]);
            //int max = Math.Max(a, Math.Max(b, c));
            //int min = Math.Min(a, Math.Min(b, c));
            //Console.WriteLine("max is " + max);
            //Console.WriteLine("min is " + min);
            #endregion
            #region q15
            //Console.WriteLine("enter number");
            //int num = int.Parse(Console.ReadLine());
            //string check = (num % 2) == 0 ? "even" : "odd";
            //Console.WriteLine(check);
            #endregion
            #region q16
            //Console.Write("enter character ");
            //char letter = Console.ReadKey().KeyChar;
            //string checker = "ieoua".Contains(letter) ? " vowel" : " consonant";
            //Console.Write(checker);
            #endregion
            #region q17
            //Console.WriteLine("enter month");
            //int month = int.Parse(Console.ReadLine());
            //int days = month switch
            //{
            //    4 or 9 or 6 or 10 or 11 => 30,
            //    2 => 28,
            //    1 or 3 or 5 or 7 or 8 or 12 => 31,
            //    _ => 0
            //};
            //Console.WriteLine(days);
            #endregion

        }

    }
}
