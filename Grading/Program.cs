using System;
using Display_helper_beginning;
//using DisplayHelper;

namespace Grading
{
 
    class Program
    {
        static void Main(string[] args)
        {
            CertificateTable table = new CertificateTable();
            //string temp;
            //string temp_2;
            //Display displayGrading = new Display(new Proportion() { Width = 40, TopLeft = new System.Drawing.Point(20, 3) });
            //displayGrading.AddItem(new LabelItem("-- Vysvědčení --"));
            //displayGrading.AddItem(new LabelItem(""));
            //Display displayInput = new Display(new Proportion() { Width = 30, TopLeft = new System.Drawing.Point(3, 3) });
            //displayInput.AddItem(new LabelItem("---- zadávání předmětu ----"));
            //displayInput.AddItem(new LabelItem("Předmět", ""));
            //Display displayInput2 = new Display(new Proportion() { Width = 30, TopLeft = new System.Drawing.Point(38, 3) });
            //displayInput2.AddItem(new LabelItem("---- zadávání známky ----"));
            //displayInput2.AddItem(new LabelItem("Známka", ""));
            //Display displayConfirm = new Display(new Proportion() { Width = 30, TopLeft = new System.Drawing.Point(25, 12) });
            //displayConfirm.AddItem(new LabelItem("Chceš vložit dalšího? [A]", ""));
            Display d1 = new Display(20, 10);
            //d1.frame();
            //d1.print();
            //d1.back();
            //temp = Console.ReadLine();
            Display d2 = new Display(50, 10);
            //d2.frame();
            //d2.print();
            //d2.back();
            //temp_2 = Console.ReadLine();
            Display d3 = new Display(35, 20);
            //d3.frame();
            //d3.print();

            
            //Display d2 = new Display("Zadej známku:" + " ", 1, 50, 10);
            //d2.frame();
            //d2.print();
            Grade[] grades = new Grade[9];
            grades[0] = new Grade() { Subject = "MAT", Score = 1 };
            grades[1] = new Grade() { Subject = "CJL", Score = 4 };
            grades[2] = new Grade() { Subject = "PRG", Score = 1 };
            grades[3] = new Grade() { Subject = "MAT", Score = 2 };
            grades[4] = new Grade() { Subject = "CJL", Score = 5 };
            grades[5] = new Grade() { Subject = "CJL", Score = 3 };
            grades[6] = new Grade() { Subject = "PRG", Score = 1 };
            grades[7] = new Grade() { Subject = "MAT", Score = 2 };
            grades[8] = new Grade() { Subject = "MAT", Score = 2 };
            d1.AddItem("-------PŘEDMĚT-------");
            d1.AddItem("Zadej předmět: ");

            d2.AddItem("-------ZNÁMKA-------");
            d2.AddItem("Zadej známku: ");

            d3.AddItem("Chceš zadat další známku [A]?");

            ConsoleKeyInfo result;
            do
            {
                int grade;
                string temp, temp_2;
                d1.frame();
                //d1.back(2);
                temp = Console.ReadLine();


                d2.frame();
                temp_2 = Console.ReadLine();
                int.TryParse(temp_2, out grade);
                if (temp.Length == 3 && grade < 6 && grade > 0) table.AddGrade(new Grade() { Score = grade, Subject = temp });

                d3.frame();
                result = Console.ReadKey();
                Console.Clear();

            } while (result.Key == ConsoleKey.A || result.Key == ConsoleKey.Enter);

            //foreach (var grade in grades)
            //{
            //    GradeAvg ga = table.AddGrade(grade);
            //}

            //foreach (var item in table.GetAllGrades())
            //{
            //    displayGrading.AddItem(new LabelItem(item.Subject, item.GetAverage()));
            //}

            //Console.Clear();
            //displayGrading.Refresh();


            Console.ReadKey();
        }
    }
}
