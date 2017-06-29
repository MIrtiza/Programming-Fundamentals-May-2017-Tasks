using System;
using Microsoft.Office.Interop.Excel;

namespace _06.EXCELlent_Knowledge
{
    class Program
    {
        static void Main()
        {
            Application xlApp = new Application();
            Workbook xlWorkbook = xlApp.Workbooks.Open(@"D:\Softuni\0.2 Tech Module - May 2017\Projects\10.ObjectsClassesFilesAndExceptiosMoreExers\06. EXCELlent Knowledge\sample_table.xlsx");
            Worksheet xlWorksheet = xlWorksheets.Sheets[1];
            Range xlRange = xlWorksheet.UsedRange;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j == 1 && i != 1)
                    {
                        Console.WriteLine();
                    }

                    Console.Write(xlRange.Cells[i, j].Value + "|");
                }
            }
        }
    }
}
// Output to paste in judge.softuni.bg

//ZIP|Sales|Name|Year|Value|
//2121|456|Jane|2011|84219|
//2092|789|Ashish|2012|28322|
//2128|456|Jane|2013|81878|
//2073|123|John|2011|44491|



/* Variant 2 - copied
 
namespace _06.ExcellentKnowledge
{
    using System;
    using System.IO;
    using System.Runtime.InteropServices;
    using Microsoft.Office.Interop.Excel;

    public class ExcellentKnowledge
    {
        public static void Main()
        {
            Application excelApp = new Application();
            Workbook excelWorkbook = excelApp.Workbooks.Open(@"D:\SoftUni\2.1.Tech-Module-Programming-Fundamentals\Лекции и Упражения\10. Programming-Fundamentals-Objects-Classes-Files-and-Exceptions-More-Exercises-Resources\sample_table.xlsx");
            _Worksheet excelWorksheet = excelWorkbook.Sheets[1];
            Range excelRange = excelWorksheet.UsedRange;

            string result = string.Empty;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    //new line
                    if (j == 1 && i != 1)
                    {
                        result += "\r\n";
                    }

                    //write the value to the console
                    if (excelRange.Cells[i, j] != null && excelRange.Cells[i, j].Value2 != null)
                    {
                        result += excelRange.Cells[i, j].Value2.ToString() + "|";
                    }
                }
            }

            File.WriteAllText("output.txt", result);

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.ReleaseComObject(excelRange);
            Marshal.ReleaseComObject(excelWorksheet);

            excelWorkbook.Close();
            Marshal.ReleaseComObject(excelWorkbook);

            excelApp.Quit();
            Marshal.ReleaseComObject(excelApp);
        }
    }
}
*/
