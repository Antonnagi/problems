using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Q1();
            
        }
        static void Q1()
        {
            int num1 = Convert.ToInt16(Console.ReadLine());
            int num2 = Convert.ToInt16(Console.ReadLine());

            int sum = num1 + num2;

            if (num1 == num2)
            {
                sum *= 3;
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
        static void Q2()
        {


            int n = Convert.ToInt16(Console.ReadLine());
            int sum = n;
            if (n <= 51)
            {
                sum = 51 - n;

                Console.WriteLine(sum);

            }
            else
            {
                sum = ((n % 10) - 1) * 3;
                Console.WriteLine(sum);

            }
            Console.ReadLine();
        }
        static void Q3()
        {
            int num1 = Convert.ToInt16(Console.ReadLine());
            int num2 = Convert.ToInt16(Console.ReadLine());

            int sum = num1 + num2;

            if (sum == 30)
            {
                Console.WriteLine("TRUE");
            }
            else
            {

                Console.WriteLine("FALSE");
            }
            Console.ReadLine();
        }
        static void Q4()
        {
            int num = Convert.ToInt16(Console.ReadLine());
            if (Math.Abs(100 - num) <= 10 || Math.Abs(200 - num) <= 10)
            {
                Console.WriteLine("TRUE");
            }
            else
            {

                Console.WriteLine("FALSE");
            }
            Console.ReadLine();
        }
        static void Q5()
        {
            String str = Console.ReadLine();
            if (str == "else")
            {
                Console.WriteLine("if else");
            }
            else
            {
                Console.WriteLine(str);

            }
            Console.ReadLine();
        }
        static void Q6()
        {
            String str = Console.ReadLine();
            int postion = Convert.ToInt16(Console.ReadLine());
            String word = str.Substring(0, postion) + str.Substring(postion + 1);
            Console.WriteLine(word);
            Console.ReadLine();
        }
        static void Q7()
        {
            string str = Console.ReadLine();
            if (str.Length <= 1)
            {
                Console.WriteLine(str);
            }
            else
            {
                char firstChar = str[0];
                char lastChar = str[str.Length - 1];
                String Word = lastChar + str.Substring(1, str.Length - 2) + firstChar;
                Console.WriteLine(Word);

            }
            Console.ReadLine();
        }
        static void Q8()
        {
            string str = Console.ReadLine();
            if (str.Length < 2)
            {
                Console.WriteLine(str);
            }
            else
            {
                String front_characters = str.Substring(0, 2);

                Console.WriteLine(front_characters + front_characters + front_characters + front_characters);

            }
            Console.ReadLine();
        }
        static void Q9()
        {
            string str = Console.ReadLine();
            char lastChar = str[str.Length - 1];
            String word = lastChar + str + lastChar;
            Console.WriteLine(word);
            Console.ReadLine();
        }
        static void Q10()
        {
            int mulp = Convert.ToInt16(Console.ReadLine());
            if (mulp % 3 == 0 || mulp % 7 == 0)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }
            Console.ReadLine();
        }
        static void Q11()
        {
            String str = Console.ReadLine();
            if (str.Length < 3)
            {
                Console.WriteLine(str + str + str);
            }
            else
            {
                String first_Three_characters = str.Substring(0, 3);
                Console.WriteLine(first_Three_characters + str + first_Three_characters);
            }
            Console.ReadLine();
        }
        static void Q12()
        {
            String str = Console.ReadLine();
            String First = str.Substring(0, 2);

            if (str.Length <= 2 && str == "C#")
            {
                Console.WriteLine("TRUE");
            }
            else if (str.Length > 2 && First == "C#")
            {
                Console.WriteLine("TRUE");

            }
            else
            {
                Console.WriteLine("FALSE");
            }
            Console.ReadLine();
        }
        static void Q13()
        {
            int num1 = Convert.ToInt16(Console.ReadLine());
            int num2 = Convert.ToInt16(Console.ReadLine());
            if ((num1 > 100 && num2 < 0) || (num2 > 100 && num1 < 0))
            {

                Console.WriteLine("TRUE");

            }
            else
            {
                Console.WriteLine("FALSE");
            }
            Console.ReadLine();
        }
        static void Q14()
        {
            int num1 = Convert.ToInt16(Console.ReadLine());
            int num2 = Convert.ToInt16(Console.ReadLine());
            if ((num1 >= 100 && num1 <= 200) && (num2 >= 100 && num2 <= 200))
            {
                Console.WriteLine("TRUE");

            }
            else
            {
                Console.WriteLine("FALSE");
            }
            Console.ReadLine();
        }
        static void Q15()
        {
            int num1 = Convert.ToInt16(Console.ReadLine());
            int num2 = Convert.ToInt16(Console.ReadLine());
            int num3 = Convert.ToInt16(Console.ReadLine());
            if ((num1 >= 20 && num1 <= 50) || (num2 >= 20 && num2 <= 50) || (num3 >= 20 && num3 <= 50))
            {
                Console.WriteLine("TRUE");

            }
            else
            {
                Console.WriteLine("FALSE");
            }
            Console.ReadLine();
        }
        static void Q16()
        {
            int num1 = Convert.ToInt16(Console.ReadLine());
            int num2 = Convert.ToInt16(Console.ReadLine());
            if ((num1 >= 20 && num1 <= 50) ^ (num2 >= 20 && num2 <= 50))
            {
                Console.WriteLine("TRUE");

            }
            else
            {
                Console.WriteLine("FALSE");
            }
            Console.ReadLine();
        }
        static void Q17()
        {
            String str = Console.ReadLine();
            String comp = str.Substring(1, 2);
            if (comp == "yt")
            {
                String word = str.Substring(0, 1) + str.Substring(2 + 1);
                Console.WriteLine(word);
            }
            else
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
        static void Q18()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int largestNum = 0;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    largestNum = num1;
                }
                else
                {
                    largestNum = num3;
                }
            }
            else
            {
                if (num2 > num3)
                {
                    largestNum = num2;
                }
                else
                {
                    largestNum = num3;
                }
            }

            Console.WriteLine(largestNum);
            Console.ReadLine();
        }
        static void Q19()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine(0);
            }
            else if (Math.Abs(num1 - 100) < Math.Abs(num2 - 100))
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }
            Console.ReadLine();
        }
        void Q20()
        {

            int num1 = Convert.ToInt16(Console.ReadLine());
            int num2 = Convert.ToInt16(Console.ReadLine());
            if (((num1 >= 40 && num1 <= 50) && (num2 >= 40 && num2 <= 50)) || ((num1 >= 50 && num1 <= 60) && (num2 >= 50 && num2 <= 60)))
            {
                Console.WriteLine("TRUE");

            }
            else
            {
                Console.WriteLine("FALSE");
            }
            Console.ReadLine();
        }
        static void Q21()
        {
            int num1 = Convert.ToInt16(Console.ReadLine());
            int num2 = Convert.ToInt16(Console.ReadLine());
            if ((num1 >= 20 && num1 <= 30) && (num2 >= 20 && num2 <= 30))
            {
                if (num1 >= num2)
                {
                    Console.WriteLine(num1);
                }
                else
                {
                    Console.WriteLine(num2);
                }
            }
            else
            {
                Console.WriteLine(0);
            }
            Console.ReadLine();
        }
        static void Q22()
        {
            String str = Console.ReadLine();
            int zCounter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'z')
                {
                    zCounter++;
                }
            }
            if (zCounter >= 2 && zCounter <= 4)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadLine();
        }
        static void Q23()
        {
            int num1 = Convert.ToInt16(Console.ReadLine());
            int num2 = Convert.ToInt16(Console.ReadLine());

            if (num1 % 10 == num2 % 10)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }
            Console.ReadLine();
        }
        static void Q24()
        {
            String str = Console.ReadLine();
            if (str.Length < 3)
            {
                Console.WriteLine(str.ToUpper());
            }
            else
            {
                String lastThree = str.Substring(str.Length - 3).ToUpper();
                String word = str.Substring(0, str.Length - 3);
                Console.WriteLine(word + lastThree);
            }
            Console.ReadLine();
        }
        static void Q25()
        {
            String str = Console.ReadLine();
            int n = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(str);
            }
            Console.ReadLine();
        }
        static void A26()
        {
            Console.Write("Input 1st number:");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Input 2nd number:");
            int num2 = Convert.ToInt16(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine(num1 + " and " + num2 + " are equal");
            }
            else
            {
                Console.WriteLine(num1 + " and " + num2 + " are not equal");
            }
            Console.ReadLine();
        }
        static void A27()
        {
            int num1 = Convert.ToInt16(Console.ReadLine());
            if (num1 % 2 == 0)
            {
                Console.WriteLine(num1 + " is an even integer");

            }
            else
            {
                Console.WriteLine(num1 + " is an odd integer");
            }
            Console.ReadLine();
        }
        static void A28()
        {
            int num1 = Convert.ToInt16(Console.ReadLine());
            if (num1 > 0)
            {
                Console.WriteLine(num1 + " is a positive number");
            }
            else if (num1 < 0)
            {
                Console.WriteLine(num1 + " is a negative number");

            }
            else
            {
                Console.WriteLine(num1 + " is a zero");

            }
            Console.ReadLine();
        }
        static void A29()
        {
            int year = Convert.ToInt16(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine(year + " is a leap year.");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year.");
            }
            Console.ReadLine();
        }
        static void A30()
        {
            int age = Convert.ToInt16(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Congratulations! You are eligible for casting your vote.");
            }
            else
            {
                Console.WriteLine("Sorry, you are not eligible for casting your vote.");
            }
            Console.ReadLine();
        }
        static void A31()
        {
            int num = Convert.ToInt16(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine(1);
            }
            else if (num == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(-1);
            }
            Console.ReadLine();

        }
        static void A32()
        {
            int height = Convert.ToInt16(Console.ReadLine());

            if (height < 150)
            {
                Console.WriteLine("The person is Dwarf.");
            }
            else if (height >= 150 && height < 165)
            {
                Console.WriteLine("The person is Average height.");
            }
            else if (height >= 165 && height < 195)
            {
                Console.WriteLine("The person is Tall.");
            }
            else
            {
                Console.WriteLine("The person is Very tall.");
            }
            Console.ReadLine();

        }
        static void A33()
        {
            Console.Write("Input the 1st number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Input the 2nd number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Input the 3rd number: ");
            int num3 = int.Parse(Console.ReadLine());
            int max = num1;

            if (num2 > max)
            {
                max = num2;
            }

            if (num3 > max)
            {
                max = num3;
            }

            if (max == num1)
            {
                Console.WriteLine("The 1st is the greatest among  three.");
            }
            else if (max == num2)
            {
                Console.WriteLine("The 2nd is the greatest among  three.");
            }
            else
            {
                Console.WriteLine("The 3rd is the greatest among  three.");
            }
            Console.ReadLine();

        }
        static void A34()
        {
            Console.Write("Input the value for X coordinate: ");
            int x = Convert.ToInt16(Console.ReadLine());

            Console.Write("Input the value for Y coordinate: ");
            int y = Convert.ToInt16(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("The coordinate point (" + x + "," + y + ") lies in the First quadrant.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The coordinate point (" + x + "," + y + ") lies in the Second quadrant.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The coordinate point (" + x + "," + y + ") lies in the Third quadrant.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The coordinate point (" + x + "," + y + ") lies in the Fourth quadrant.");
            }
            else
            {
                Console.WriteLine("The coordinate point (" + x + "," + y + ") lies at the origin.");
            }
            Console.ReadLine();

        }
        static void A35()
        {
            Console.Write("Input the marks obtained in Physics: ");
            int physics = Convert.ToInt16(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry: ");
            int chemistry = Convert.ToInt16(Console.ReadLine());

            Console.Write("Input the marks obtained in Mathematics: ");
            int maths = Convert.ToInt16(Console.ReadLine());

            int totalMarks = physics + chemistry + maths;

            if (maths >= 65 && physics >= 55 && chemistry >= 50 && totalMarks >= 180)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else if (maths + physics + chemistry >= 140 && maths >= 65)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
            Console.ReadLine();
        }
        static void A36()
        {
            Console.Write("Input the value of a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input the value of b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input the value of c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double equation = b * b - 4 * a * c;

            if (equation < 0)
            {
                Console.WriteLine("Roots are imaginary.");
            }
            else if (equation == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine("The root of the quadratic equation is: " + root);
            }
            else
            {
                double root1 = (-b + Math.Sqrt(equation)) / (2 * a);
                double root2 = (-b - Math.Sqrt(equation)) / (2 * a);
                Console.WriteLine("The roots of the quadratic equation are: " + root1 + " and " + root2);
            }
            Console.ReadLine();

        }
        static void A37()
        {
            Console.Write("Input the Roll Number of the student: ");
            int rollNo = Convert.ToInt16(Console.ReadLine());

            Console.Write("Input the Name of the Student: ");
            string name = Console.ReadLine();

            Console.Write("Input the marks of Physics, Chemistry and Computer Application: ");
            string[] subjectMark = Console.ReadLine().Split(' ');
            int physics = Convert.ToInt16(subjectMark[0]);
            int chemistry = Convert.ToInt16(subjectMark[1]);
            int computer = Convert.ToInt16(subjectMark[2]);

            int totalMarks = physics + chemistry + computer;
            double percentage = (double)totalMarks / 3;

            Console.WriteLine("Roll No: " + rollNo);
            Console.WriteLine("Name of Student: " + name);
            Console.WriteLine("Marks in Physics: " + physics);
            Console.WriteLine("Marks in Chemistry: " + chemistry);
            Console.WriteLine("Marks in Computer Application: " + computer);
            Console.WriteLine("Total Marks: " + totalMarks);
            Console.WriteLine("Percentage: " + percentage.ToString("0.00"));

            if (percentage >= 60)
            {
                Console.WriteLine("Division: First");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine("Division: Second");
            }
            else if (percentage >= 40)
            {
                Console.WriteLine("Division: Third");
            }
            else
            {
                Console.WriteLine("Division: Fail");
            }
            Console.ReadLine();
        }
        static void A38()
        {
            Console.Write("Enter temperature in centigrade: ");
            int temp = Convert.ToInt16(Console.ReadLine());

            if (temp < 0)
            {
                Console.WriteLine("Freezing weather.");
            }
            else if (temp >= 0 && temp <= 10)
            {
                Console.WriteLine("Very cold weather.");
            }
            else if (temp > 10 && temp <= 20)
            {
                Console.WriteLine("Cold weather.");
            }
            else if (temp > 20 && temp <= 30)
            {
                Console.WriteLine("Normal in temp.");
            }
            else if (temp > 30 && temp <= 40)
            {
                Console.WriteLine("It's hot.");
            }
            else
            {
                Console.WriteLine("It's very hot.");

            }
            Console.ReadLine();

        }
        static void A39()
        {
            string[] triangleSide = Console.ReadLine().Split(' ');
            int side1 = int.Parse(triangleSide[0]);
            int side2 = int.Parse(triangleSide[1]);
            int side3 = int.Parse(triangleSide[2]);

            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("This is an equilateral triangle.");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("This is an isosceles triangle.");
            }
            else
            {
                Console.WriteLine("This is a scalene triangle.");
            }
            Console.ReadLine();

        }
        static void A40()
        {
            string[] anglesSide = Console.ReadLine().Split(' ');
            int angle1 = int.Parse(anglesSide[0]);
            int angle2 = int.Parse(anglesSide[1]);
            int angle3 = int.Parse(anglesSide[2]);

            int sumOfAngles = angle1 + angle2 + angle3;

            if (sumOfAngles == 180)
            {
                Console.WriteLine("The triangle is valid.");
            }
            else
            {
                Console.WriteLine("The triangle is not valid.");
            }
            Console.ReadLine();
        }
        static void A41()
        {
            char letter = Convert.ToChar(Console.ReadLine().ToLower());

            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                Console.WriteLine("The alphabet is a vowel.");
            }
            else
            {
                Console.WriteLine("The alphabet is a consonant.");
            }
            Console.ReadLine();
        }
        static void A42()
        {
            int cost = Convert.ToInt16(Console.ReadLine());
            int selling = Convert.ToInt16(Console.ReadLine());

            int profit = selling - cost;
            int loss = cost - selling;

            if (profit > 0)
            {
                Console.WriteLine("You can book your profit amount: " + profit);
            }
            else if (loss > 0)
            {
                Console.WriteLine("You have incurred a loss of: " + loss);
            }
            else
            {
                Console.WriteLine("You have neither made a profit nor incurred a loss.");
            }
            Console.ReadLine();

        }
        static void A43()
        {
            Console.Write("Enter customer ID: ");
            int customerID = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter customer name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter unit consumed: ");
            int unitConsumed = Convert.ToInt16(Console.ReadLine());

            double amountCharges = 0;
            if (unitConsumed <= 199)
            {
                amountCharges = unitConsumed * 1.20;
            }
            else if (unitConsumed >= 200 && unitConsumed < 400)
            {
                amountCharges = unitConsumed * 1.50;
            }
            else if (unitConsumed >= 400 && unitConsumed < 600)
            {
                amountCharges = unitConsumed * 1.80;
            }
            else if (unitConsumed >= 600)
            {
                amountCharges = unitConsumed * 2.00;
            }
            double surcharge = 0;

            if (amountCharges > 400)
            {
                surcharge = amountCharges * 0.15;
            }

            double netAmount = amountCharges + surcharge;

            if (netAmount < 100)
            {
                netAmount = 100;
            }

            Console.WriteLine("Customer IDNO: " + customerID);
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Unit Consumed: " + unitConsumed);
            Console.WriteLine("Amount Charges @Rs. " + (amountCharges / unitConsumed).ToString("F2") + " per unit: " + amountCharges.ToString("F2"));
            Console.WriteLine("Surchage Amount: " + surcharge.ToString("F2"));
            Console.WriteLine("Net Amount Paid By the Customer: " + netAmount.ToString("F2"));
            Console.ReadLine();

        }
        static void A44()
        {
            char grade = Convert.ToChar(Console.ReadLine().ToUpper());
            switch (grade)
            {
                case 'E':
                    Console.WriteLine("Excellent");
                    break;
                case 'V':
                    Console.WriteLine("Very Good");
                    break;
                case 'G':
                    Console.WriteLine("Good");
                    break;
                case 'A':
                    Console.WriteLine("Average");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
            Console.ReadLine();
        }
        static void A45()
        {
            int dayNumber = Convert.ToInt16(Console.ReadLine());

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;
            }
            Console.ReadLine();

        }
        static void A46()
        {
            int digit = Convert.ToInt16(Console.ReadLine());

            switch (digit)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                case 10:
                    Console.WriteLine("ten");
                    break;
                default:
                    Console.WriteLine("Invalid digit");
                    break;
            }
            Console.ReadLine();

        }
        static void A47()
        {
            int monthNumber = Convert.ToInt16(Console.ReadLine());

            switch (monthNumber)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Invalid month number");
                    break;
            }
            Console.ReadLine();

        }
        static void A48()
        {
            int monthNumber = Convert.ToInt16(Console.ReadLine());

            switch (monthNumber)
            {
                case 1:
                    Console.WriteLine("January has 31 days");
                    break;
                case 2:
                    Console.WriteLine("February has 28 days (29 days in leap years)");
                    break;
                case 3:
                    Console.WriteLine("March has 31 days");
                    break;
                case 4:
                    Console.WriteLine("April has 30 days");
                    break;
                case 5:
                    Console.WriteLine("May has 31 days");
                    break;
                case 6:
                    Console.WriteLine("June has 30 days");
                    break;
                case 7:
                    Console.WriteLine("July has 31 days");
                    break;
                case 8:
                    Console.WriteLine("August has 31 days");
                    break;
                case 9:
                    Console.WriteLine("September has 30 days");
                    break;
                case 10:
                    Console.WriteLine("October has 31 days");
                    break;
                case 11:
                    Console.WriteLine("November has 30 days");
                    break;
                case 12:
                    Console.WriteLine("December has 31 days");
                    break;
                default:
                    Console.WriteLine("Invalid month number");
                    break;
            }
            Console.ReadLine();

        }
        static void A49()
        {
            Console.WriteLine("1-Circle");
            Console.WriteLine("2-Square");
            Console.WriteLine("3-Rectangle");
            Console.WriteLine("4-Triangle");
            Console.Write("Input your choice: ");
            int choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Input radius of the circle: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    double circleArea = Math.PI * Math.Pow(radius, 2);
                    Console.WriteLine("The area is: " + circleArea);
                    break;
                case 2:
                    Console.Write("Input side of the square: ");
                    double side = Convert.ToDouble(Console.ReadLine());
                    double squareArea = Math.Pow(side, 2);
                    Console.WriteLine("The area is: " + squareArea);
                    break;
                case 3:
                    Console.Write("Input length of the rectangle: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input width of the rectangle: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    double rectangleArea = length * width;
                    Console.WriteLine("The area is: " + rectangleArea);
                    break;
                case 4:
                    Console.Write("Input base of the triangle: ");
                    double triangleBase = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input height of the triangle: ");
                    double triangleHeight = Convert.ToDouble(Console.ReadLine());
                    double triangleArea = 0.5 * triangleBase * triangleHeight;
                    Console.WriteLine("The area is: " + triangleArea);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.ReadLine();

        }
        static void B50()
        {
            String str = Console.ReadLine();
            Console.WriteLine("The string you entered is : " + str);
            Console.ReadLine();

        }
        static void B51()
        {
            String str = Console.ReadLine();

            int length = 0;
            foreach (char c in str)
            {
                length++;
            }

            Console.WriteLine("Length of the string is : " + length);
            Console.ReadLine();
        }
        static void B52()
        {
            Console.Write("Input the string: ");
            string str = Console.ReadLine();

            Console.WriteLine("Individual characters in the string:");
            foreach (char c in str)
            {
                Console.Write(c + " ");

            }
            Console.ReadLine();
        }
        static void B53()
        {
            String str = Console.ReadLine();
            Console.WriteLine("The characters of the string in reverse are : ");
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i] + " ");
            }
            Console.ReadLine();

        }
        static void B54()
        {
            String str = Console.ReadLine();
            String[] word = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int lenght = word.Length;
            Console.WriteLine("Total number of words in the string is: " + lenght);
            Console.ReadLine();
        }
        static void B55()
        {
            Console.Write("Input the 1st string: ");
            string str1 = Console.ReadLine();

            Console.Write("Input the 2nd string: ");
            string str2 = Console.ReadLine();

            if (str1.Length != str2.Length)
            {
                Console.WriteLine("The length of both strings are not equal.");
            }
            else
            {
                bool iSequal = true;
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        iSequal = false;
                        break;
                    }
                }

                if (iSequal)
                {
                    Console.WriteLine("The length of both strings are equal and also, both strings are equal.");
                }
                else
                {
                    Console.WriteLine("The length of both strings are equal but the strings are not equal.");
                }
            }
            Console.ReadLine();
        }
        static void B56()
        {
            Console.WriteLine("Input the String");
            String str = Console.ReadLine();
            int alpha = 0;
            int digit = 0;
            int special = 0;
            foreach (Char c in str)
            {
                if (Char.IsLetter(c))
                {
                    alpha++;
                }
                else if (Char.IsDigit(c))
                {
                    digit++;
                }
                else if (!Char.IsWhiteSpace(c))
                {
                    special++;
                }
                Console.ReadLine();
            }

            Console.WriteLine("Number of Alphabets in the string is : " + alpha);
            Console.WriteLine("Number of Digits in the string is : " + digit);
            Console.WriteLine("Number of Special characters in the string is : " + special);
        }
        static void B57()
        {
            Console.WriteLine("Input the String : ");
            String str = Console.ReadLine();
            String str2 = str;
            Console.WriteLine("The First string is : " + str);
            Console.WriteLine("The Second string is :" + str2);
            Console.WriteLine("Number of characters copied : " + str2.Length);
            Console.ReadLine();
        }
        static void B58()
        {
            Console.Write("Input the string: ");
            string str = Console.ReadLine();

            int vowels = 0;
            int consonants = 0;

            foreach (char c in str)
            {
                if (Char.IsLetter(c))
                {
                    char lowerC = Char.ToLower(c);
                    if (lowerC == 'a' || lowerC == 'e' || lowerC == 'i' || lowerC == 'o' || lowerC == 'u')
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
            }

            Console.WriteLine("The total number of vowel in the string is : {0}", vowels);
            Console.WriteLine("The total number of consonant in the string is : {0}", consonants);
            Console.ReadLine();
        }
        static void B59()
        {
            Console.Write("Input the string: ");
            string str = Console.ReadLine();

            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (Char.IsLetter(c))
                {
                    char lowerC = Char.ToLower(c);
                    if (freq.ContainsKey(lowerC))
                    {
                        freq[lowerC]++;
                    }
                    else
                    {
                        freq[lowerC] = 1;
                    }
                }
            }

            int maxFreq = 0;
            char maxChar = '\0';
            foreach (KeyValuePair<char, int> pair in freq)
            {
                if (pair.Value > maxFreq)
                {
                    maxFreq = pair.Value;
                    maxChar = pair.Key;
                }
            }

            Console.WriteLine("The Highest frequency of character '{0}' appears number of times : {1}", maxChar, maxFreq);
            Console.ReadLine();
        }
        static void B60()
        {
            Console.Write("Input the string: ");
            string str = Console.ReadLine();

            var groups = str
                .GroupBy(c => c)
                .OrderBy(g => g.Key);

            string sortedStr = string.Concat(groups.Select(g => new string(g.Key, g.Count())));

            Console.WriteLine("After sorting the string appears like:");
            Console.WriteLine(sortedStr);
            Console.ReadLine();
        }
        static void B61()
        {

            int n = Convert.ToInt16(Console.ReadLine());

            string[] strArray = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Input string {i + 1}: ");
                strArray[i] = Console.ReadLine();
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(strArray[j], strArray[j + 1]) > 0)
                    {
                        string temp = strArray[j];
                        strArray[j] = strArray[j + 1];
                        strArray[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("After sorting the array appears like:");
            foreach (string str in strArray)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
        static void B62()
        {
            string str = Console.ReadLine();

            Console.Write("Input the position to start extraction: ");
            int start = Convert.ToInt16(Console.ReadLine());

            Console.Write("Input the length of substring: ");
            int length = Convert.ToInt16(Console.ReadLine());

            string subStr = "";

            for (int i = start; i < start + length && i < str.Length; i++)
            {
                subStr += str[i];
            }

            Console.WriteLine($"The substring retrieved from the string is: {subStr}");
            Console.ReadLine();
        }
        static void B63()
        {
            Console.Write("Input the string: ");
            string str = Console.ReadLine();

            Console.Write("Input the substring to search: ");
            string subStr = Console.ReadLine();

            if (str.Contains(subStr))
            {
                Console.WriteLine("The substring exists in the string.");
            }
            else
            {
                Console.WriteLine("The substring does not exist in the string.");
            }
            Console.ReadLine();
        }
        static void B64()
        {
            string str = Console.ReadLine();

            char[] charArray = str.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsUpper(charArray[i]))
                {
                    charArray[i] = char.ToLower(charArray[i]);
                }
                else if (char.IsLower(charArray[i]))
                {
                    charArray[i] = char.ToUpper(charArray[i]);
                }
            }

            string result = new string(charArray);

            Console.WriteLine($"After conversion, the string is: {result}");
            Console.ReadLine();
        }
        static void B65()
        {
            string username = "";
            string password = "";

            while (true)
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();

                if (username == "user" && password == "pass")
                {
                    Console.WriteLine("Password entered successfully!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect username or password. Please try again.");
                }
            }
            Console.ReadLine();
        }
        static void B66()
        {
            Console.Write("Input a string: ");
            string str = Console.ReadLine();

            Console.Write("Input a substring to be found in the string: ");
            string subStr = Console.ReadLine();

            int pos = str.IndexOf(subStr);

            if (pos != -1)
            {
                Console.WriteLine($"Found '{subStr}' in '{str}' at position {pos}");
            }
            else
            {
                Console.WriteLine($"Substring '{subStr}' not found in '{str}'");
            }
            Console.ReadLine();
        }
        static void B67()
        {
            Console.Write("Input a character: ");
            char ch = Console.ReadKey().KeyChar;

            if (Char.IsLetter(ch))
            {
                if (Char.IsUpper(ch))
                {
                    Console.WriteLine("\nThe character is uppercase.");
                }
                else
                {
                    Console.WriteLine("\nThe character is lowercase.");
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nThe character is not an alphabet.");
            }
            Console.ReadLine();
        }
        static void B68()
        {
            Console.Write("Input the original string: ");
            string str = Console.ReadLine();

            Console.Write("Input the string to be searched for: ");
            string subStr = Console.ReadLine();

            int count = 0;
            int pos = str.IndexOf(subStr);

            while (pos != -1)
            {
                count++;
                pos = str.IndexOf(subStr, pos + 1);
            }

            Console.WriteLine($"The string '{subStr}' occurs {count} times");
            Console.ReadLine();
        }
        static void B69()
        {
            Console.Write("Input the original string: ");
            string str = Console.ReadLine();

            Console.Write("Input the string to be searched for: ");
            string searchStr = Console.ReadLine();

            Console.Write("Input the string to be inserted: ");
            string insertStr = Console.ReadLine();

            int pos = str.IndexOf(searchStr);

            if (pos != -1)
            {
                string newStr = str.Insert(pos, insertStr);
                Console.WriteLine($"The modified string is: {newStr}");
            }
            else
            {
                Console.WriteLine($"The string '{searchStr}' was not found in '{str}'");
            }
            Console.ReadLine();
        }
        static void B70()
        {
            string str1 = "computer";
            string str2 = "system";

            string subStr1 = str1.Substring(3, 2);
            string subStr2 = str2.Substring(0, 2);

            if (String.Compare(subStr1, subStr2) < 0)
            {
                Console.WriteLine($"Substring '{subStr1}' in '{str1}' is less than substring '{subStr2}' in '{str2}'.");
            }
            else if (String.Compare(subStr1, subStr2) > 0)
            {
                Console.WriteLine($"Substring '{subStr1}' in '{str1}' is greater than substring '{subStr2}' in '{str2}'.");
            }
            else
            {
                Console.WriteLine($"Substring '{subStr1}' in '{str1}' is equal to substring '{subStr2}' in '{str2}'.");
            }
            Console.ReadLine();
        }
        static void B71()
        {
            string str1 = "COMPUTER";
            string str2 = "computer";

            string subStr1 = str1.Substring(3, 2);
            string subStr2 = str2.Substring(3, 2);

            // Ignore case
            if (String.Compare(subStr1, subStr2, StringComparison.OrdinalIgnoreCase) == 0)
            {
                Console.WriteLine($"Ignore case:\nSubstring '{subStr1}' in '{str1}' is equal to substring '{subStr2}' in '{str2}'.");
            }
            else
            {
                Console.WriteLine($"Ignore case:\nSubstring '{subStr1}' in '{str1}' is not equal to substring '{subStr2}' in '{str2}'.");
            }

            // Honor case
            if (String.Compare(subStr1, subStr2) < 0)
            {
                Console.WriteLine($"Honor case:\nSubstring '{subStr1}' in '{str1}' is less than substring '{subStr2}' in '{str2}'.");
            }
            else if (String.Compare(subStr1, subStr2) > 0)
            {
                Console.WriteLine($"Honor case:\nSubstring '{subStr1}' in '{str1}' is greater than substring '{subStr2}' in '{str2}'.");
            }
            else
            {
                Console.WriteLine($"Honor case:\nSubstring '{subStr1}' in '{str1}' is equal to substring '{subStr2}' in '{str2}'.");
            }
            Console.ReadLine();
        }
        static void B73()
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();

            string lastName1 = name1.Substring(name1.LastIndexOf(' ') + 1);
            string lastName2 = name2.Substring(name2.LastIndexOf(' ') + 1);

            int result = string.Compare(lastName1, lastName2, StringComparison.CurrentCultureIgnoreCase);

            if (result < 0)
            {
                Console.WriteLine($"{name1}\n{name2}");
            }
            else
            {
                Console.WriteLine($"{name2}\n{name1}");
            }
            Console.ReadLine();
        }
        static void B74()
        {
            string str1 = "encyclopedia";
            string str2 = "Encyclopedia";

            CultureInfo[] cultures = { CultureInfo.CurrentCulture, CultureInfo.InvariantCulture, new CultureInfo("se-SE") };
            StringComparison[] comparisons = { StringComparison.CurrentCulture, StringComparison.CurrentCultureIgnoreCase, StringComparison.InvariantCulture, StringComparison.InvariantCultureIgnoreCase, StringComparison.Ordinal, StringComparison.OrdinalIgnoreCase };

            foreach (CultureInfo culture in cultures)
            {
                Console.WriteLine($"{culture.DisplayName}:");
                foreach (StringComparison comparison in comparisons)
                {
                    Console.WriteLine($"  {comparison} = {String.Equals(str1, str2, comparison)}");
                }
            }
            Console.ReadLine();
        }
        static void B75()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i} ");
            }
            Console.ReadLine();
        }
        static void C76()
        {
            int sum = 0;

            Console.Write("The first 10 natural numbers are: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine($"\nThe sum is: {sum}");
            Console.ReadLine();

        }
        static void C77()
        {
            Console.Write("Enter a positive integer: ");
            int n = Convert.ToInt16(Console.ReadLine());

            int sum = 0;
            Console.Write($"The first {n} natural numbers are: ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine($"\nThe sum of the first {n} natural numbers is: {sum}");
            Console.ReadLine();

        }
        static void C78()
        {
            int sum = 0;
            double average = 0;

            Console.WriteLine("Enter 10 integers:");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Number-{i}: ");
                int num = Convert.ToInt16(Console.ReadLine());
                sum += num;
            }

            average = (double)sum / 10;

            Console.WriteLine($"The sum of the 10 numbers is: {sum}");
            Console.ReadLine();

        }
        static void C79()
        {
            Console.Write("Input number of terms: ");
            int n = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Cube of integers up to {0}:", n);
            for (int i = 1; i <= n; i++)
            {
                int cube = i * i * i;
                Console.WriteLine($"Number is: {i} and cube of the {i} is: {cube}");
            }
            Console.ReadLine();

        }
        static void C80()
        {
            Console.Write("Input the number (Table to be calculated): ");
            int n = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"Multiplication table of {n}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
            Console.ReadLine();
        }
        static void C81()
        {
            Console.Write("Input upto the table number starting from 1: ");
            int n = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"Multiplication table from 1 to {n}");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write($"{j}x{i} = {i * j}");
                    if (j != n)
                    {
                        Console.Write(", ");
                    }
                }
            }
            Console.ReadLine();
        }
            static void C82()
            {
                Console.Write("Input number of terms: ");
                int num = int.Parse(Console.ReadLine());

                int sum = 0;
                Console.Write("The odd numbers are: ");
                for (int i = 1; i <= num; i++)
                {
                    int odd = 2 * i - 1;
                    Console.Write($"{odd} ");
                    sum += odd;
                }
                Console.WriteLine($"\nThe Sum of odd Natural Number upto {n} terms: {sum}");
            Console.ReadLine();
        }
            static void C83()
            {
                int star = int.Parse(Console.ReadLine());

                for (int i = 1; i <= star; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                }
            Console.ReadLine();
        }
        static void C84()
        {
            Console.Write("Enter the number of terms: ");
                int terms = int.Parse(Console.ReadLine());
                int sum = 0;
                Console.Write("The odd numbers are: ");
                for (int i = 1; i <= terms; i++)
                {
                    int oddNumber = 2 * i - 1;
                    Console.Write(oddNumber + " ");
                    sum += oddNumber;
                }
                Console.WriteLine();
                Console.WriteLine("The Sum of odd Natural Numbers up to " + terms + " terms: " + sum);
            Console.ReadLine();
        }
        static void C85()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
        static void C86()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
           for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void C87()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void C88()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            int number = 1;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void C89()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            int number = 1;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(number + " ");
                    number++;
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void C90()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void C91()
        {
            Console.Write("Input the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("The Factorial of " + number + " is: " + factorial);
            Console.ReadLine();
        }
        static void C92()
        {
            Console.Write("Input number of terms: ");
            int numTerms = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.Write("The even numbers are: ");
            for (int i = 1; i <= numTerms; i++)
            {
                int evenNumber = 2 * i;
                sum += evenNumber;
                Console.Write(evenNumber + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The Sum of even Natural Number upto " + numTerms + " terms: " + sum);
            Console.ReadLine();
        }
        static void C93()
        {
            Console.WriteLine("Enter the number of rows for the pyramid:");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                   Console.Write(i + " ");
                }
               Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void C94()
        {
            Console.Write("Input the Value of x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the number of terms: ");
            int numTerms = Convert.ToInt32(Console.ReadLine());
            double sum = 1.0;
            double power = 1.0;
            double factorial = 1.0;
            int sign = -1;
            for (int i = 2; i <= 2 * numTerms; i += 2)
            {
                power *= x * x;
                factorial *= i * (i - 1);
                sum += sign * (power / factorial);
                sign *= -1;
            }
            Console.WriteLine("The sum = " + sum.ToString("F6"));
            Console.WriteLine("Number of terms = " + numTerms);
            Console.WriteLine("Value of x = " + x.ToString("F6"));
            Console.ReadLine();
        }
    }
}
