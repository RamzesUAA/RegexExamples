using System;
using System.Text.RegularExpressions;

namespace Regex_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Regex for e-mail
            Regex myReg = new Regex(@"[A-Za-z]+[\. A-Za-z0-9 _-]*[A-Za-z0-9]+@[A-Za-z]+\.[A-Za-z]+");
            Console.WriteLine(myReg.IsMatch("email@email.com"));  // True
            Console.WriteLine(myReg.IsMatch("emai7l@email.com")); // True
            Console.WriteLine(myReg.IsMatch("email@email.UA")); // True
            Console.WriteLine(myReg.IsMatch("roma.email@email.UA")); // True
            Console.WriteLine(myReg.IsMatch("romaemail@email.UA")); // True
            Console.WriteLine(myReg.IsMatch("2mai7l@email.UA")); // True
            Console.WriteLine(myReg.IsMatch("email@em4ail.com")); //False
            Console.WriteLine(myReg.IsMatch("email @email .com")); //False
            Console.WriteLine(myReg.IsMatch("emailemail.com")); //False
            Console.WriteLine(myReg.IsMatch("@emailemail.com")); //False



            //string testStr = "abc";
            //Regex regex = new Regex("[a-z]");
            //Match match1 = regex.Match(testStr);
            //MatchCollection matches = regex.Matches(testStr);
            //match1 = matches[0];



            //string data = "user1@gmail.com";

            //string pattern1 = "[a-g]";//проміжок 1 символ
            //string pattern11 = "[a-g]+";//проміжок 1 і більше символів
            //string pattern12 = "abc";//символи abc в цьому порядку
            //string pattern13 = "[abc]"; //будь який з abc 
            //string pattern14 = "[^a-d]";// будь який не з a-d
            //string pattern2 = "[a-g]{3}";//проміжок і довжина перевірки
            //string pattern3 = "^[a-g]{3}$"; //^ - на початку $ - в кінці
            //string pattern4 = "^[a-g]{1,3}$"; // від 1 до 3 
            //string pattern5 = "^[0-9]{8}$";// 8 чисел (від 0 до 9)
            //string pattern6 = "^[0-9]{3,7}$";//числa (від 0 до 9) кількість : 3-7
            //string pattern7 = "^[a-z]{3}[0-9]{8}$";//перші 3 букви далі 8 цифр
            //string pattern8 = "^[a-zA-Z]{3}[0-9]{8}$";//перші 3 букви(нижній і верхній регістр) далі 8 цифр
            //string pattern9 = "^[w]{3}[.][a-z0-9A-Z]{1,10}[.](com|org)$";//url веб сайта www.nicewebsite.com
            //string pattern10 = "^[a-z0-9A-Z]{1,10}[@](gmail)[.](com)$";//email gmail
            //string pattern15 = "."; // != \n \t
            //string pattern20 = @"\w";// == [a-zA-Z0-9]
            //string pattern21 = @"\W";// == [^\w]
            //string pattern16 = @"\d";//[0-9] digit
            //string pattern17 = @"\D";//[^0-9] Non-digit
            //string pattern18 = @"\s";//пробіл або символи \n \t ...
            //string pattern19 = @"\S";// == [^\s]

            //Regex regObj = new Regex("^[a-z0-9A-Z]{1,10}[@](gmail)[.](com)$");
            //bool check = regObj.IsMatch(data);
            //Console.WriteLine(check);


            //string data = "1000/03/30 00:59";
            ////year         //month             //day                    //hour                    //minutes
            //Regex regObj = new Regex(@"^[1000-2012]{4}/(0[1-9]|1[012])/(0[1-9]|[12]\d|3[0]) (0[0-9]|1[0-9]|2[0-3]):(0[1-9]|[10-59]{2})$");
            //bool check = regObj.IsMatch(data);
            //Console.WriteLine($"checking data: {check}");


            //string ip = "0x4F.255.255.0x12";
            //Regex regexIP = new Regex(@"^([0-9]{1,3}|0x[A-F0-9]{2}).([0-9]{1,3}|0x[A-F0-9]{2}).([0-9]{1,3}|0x[A-F0-9]{2}).([0-9]{1,3}|0x[A-F0-9]{2})$");
            //bool checkIP = regexIP.IsMatch(ip);
            //Console.WriteLine($"checking IP: { checkIP}");


        }
    }
}
