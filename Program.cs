
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
            Console.WriteLine("General opperations");
            Console.WriteLine("What do you want to do?\n");
            Console.WriteLine(" ns/<faculty abbreviation>/<first name>/<last name>/<email>/<day>/<month>/<year> - create student");
            Console.WriteLine(" gs/<email> - (g)raduate (s)tudent");
            Console.WriteLine(" ds/<faculty abbreviation> - (d)isplay enrolled (s)tudents");
            Console.WriteLine(" dg/<faculty abbreviation> - (d)ispaly (g)raduated students");
            Console.WriteLine(" bf/<faculty abbreviation>/<email> - check if student (b)elong to (f)aculty\n\n");
            Console.WriteLine(" b - Back\n");
            Console.WriteLine(" q - Quit Program\n\n");
            Console.Write("your input> ");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.StartsWith("q")) { goto end; }
                if (input.StartsWith("b")) { break; }
                if (input.StartsWith("ns/")){/*=======CREATE STUDENT FUNCTION=======*/}
                if (input.StartsWith("gs/")){/*=======GRADUATE STUDENT FUNCTION=======*/}
                if (input.StartsWith("ds")) {/*=======DISPLAY ENROLLED STUDENTS FUNCTION=======*/}
                if (input.StartsWith("dg/")){/*=======DISPLAY GRADUATED STUDENTS FUNCTION=======*/}
                if (input.StartsWith("bf/")){/*=======IF STUDENT BELONG TO FACULTY FUNCTION=======*/}
            }


            goto start;
        std:;
            Console.Clear();
            Console.WriteLine("NUI НИХУЯ SCRIS IN FAILUL CU LUCRARE. НЕ ЕБЁТ!!");

            goto start;
        end:;
        Console.WriteLine("Ending the Program...");
        }
    }
}
