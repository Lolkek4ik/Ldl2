using System.Runtime.CompilerServices;

namespace Ldl2
{
    internal class Program
    {
        static void Main()
        {
        start:;
            Console.Clear();
            Console.WriteLine("                    ``                          ");
            Console.WriteLine("Welcome to  UTM's student manager system !      ");
            Console.WriteLine("What do you want to do?\n");
            Console.WriteLine(" g - General opperations\n");
            Console.WriteLine(" f - Faculty opperations\n");
            Console.WriteLine(" s - Student opperations\n\n");
            Console.WriteLine(" q - Quit Program\n\n");
            Console.Write("your input> ");
            char act1 = Convert.ToChar(Console.Read());

            switch(act1) 
            { 
                case 'g': goto grl;
                case 'f': goto fct;
                case 's': goto std;
                case 'q':goto end;
            }

        grl:;
            Console.Clear();
            Console.WriteLine("General opperations");
            Console.WriteLine("What do you want to do?\n");
            Console.WriteLine(" nf/<faculty name>/<faculty abbreviation>/<field> - creat new faculty");
            Console.WriteLine(" ss/<student email> - search student and show faculty");
            Console.WriteLine(" df - display faculties");
            Console.WriteLine(" df/<field> - display all faculties of a field\n\n");
            Console.WriteLine(" b - Back\n");
            Console.WriteLine(" q - Quit Program\n\n");
            Console.Write("your input> ");
            while (true) 
            { 
                string input = Console.ReadLine();
                if (input.StartsWith("q")){ goto end; }
                if (input.StartsWith("b")){ break; }
                if (input.StartsWith("nf/")) {/*=======NEW FACULTY FUNCTION=======*/}
                if (input.StartsWith("ss/")) {/*=======SEARCH STUDENT FUNCTION=======*/}
                if (input.StartsWith("df")) {/*=======DISPLAY FACULTIES FUNCTION=======*/}
                if (input.StartsWith("df/")) {/*=======DISPLAY FACULTIES OF A FIELD FUNCTION=======*/}  
            }

        goto start;
        fct:;
            Console.Clear();


        goto start;
        std:;
            Console.Clear();


        goto start;
        end:;
        Console.WriteLine("Ending the Program...");
        }
    }
}
