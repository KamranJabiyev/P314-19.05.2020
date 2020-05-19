using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables,DataType
            //Paskal Case
            //string TheacherName = "Kamran";
            //Camel case
            //string teacherName = "Kamran";
            //Snake case
            //string teacher_name = "Kamran";
            //Kebab case
            //string teacher-name = "Kamran"; c# bu adlandirmani desteklemir!!!
            //int a = 5;
            //int b = 6;
            //string word = "Hello";
            ////string word = "Hi";
            //word = "a";
            //char letter = '@';

            //bool isMaried = true;
            //isMaried = false;
            //byte age = 255;

            //decimal pi = 3.14M;
            //float radian = 1.5F;
            //double x = 3;

            //Console.WriteLine(word);
            #endregion

            #region Condition
            //int age = 31;

            //if (age > 18)
            //{
            //    if (age < 30)
            //    {
            //        Console.WriteLine("Xosh gelmisiniz");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Yashiniz choxdur");
            //    }

            //}
            //else if(age==18)
            //{
            //    Console.WriteLine("Yashiniz 18-dir");
            //}
            //else
            //{
            //    Console.WriteLine("Yashiniz chatmir");
            //}

            #endregion

            #region Switch case
            //int age = 16;

            //switch (age)
            //{
            //    case 19:
            //        Console.WriteLine("Yashiniz 19");
            //        break;
            //    case 18:
            //        Console.WriteLine("Yashiniz 18");
            //        break;
            //    case 17:
            //        Console.WriteLine("Yashiniz 17");
            //        break;
            //    default:
            //        Console.WriteLine("Uygun deyil");
            //        break;
            //}
            #endregion

            #region Loops
            //int i = 1;
            //while (i < 0)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 1;

            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i < 0);

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            string[] stu = { "Zahid", "Seynur", "Javidan" };
            int[] numbers = { 123, 43556, 213, 12 };

            //for (int i = 0; i < stu.Length; i++)
            //{
            //    Console.WriteLine(stu[i]);
            //}

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }

}

