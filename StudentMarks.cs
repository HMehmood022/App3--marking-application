using System;//Allows us to make use of the system library.     

namespace StudentMarks //namespace used to organise our code elements.
{
    public class StudentMarks// our application class
    {
        public const int Maxstudents = 10;// this is the max amount of students in our student array.
        public static int[] Marks { get; set; } = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };//this is the Marks array
        public static string[] Students { get; set; } = {" Student01 ", " Student02 ", " Student03 ", " Student04 ", " Student05 ", " Student06 ", " Student07 ", " Student08 ", " Student09 ", " Student10 "};// these are the names of the students in our student array

        public static void Main()
        {

            SelectChoice();

        }

        public static void SelectChoice() //This is selection method, it will be called so that the user can select another option.
        {

            int choice = 0;

            Console.ForegroundColor = ConsoleColor.Green;// this property is used change our console colours. Our console text colour will be green.
            Console.WriteLine(" ------------------------------------------------- ");
            Console.WriteLine(" Welcome to Hishaam's student marking application! "); //our opening message.
            Console.WriteLine(" ------------------------------------------------- ");
            Console.WriteLine(" Please select an option from below: "); // the usaer is presented with 4 options.
            Console.WriteLine(" ------------------------------------------------- ");
            Console.WriteLine(" 1 - Input Marks "); 
            Console.WriteLine(" 2 - Output Marks ");
            Console.WriteLine(" 3 - Output Stats ");
            Console.WriteLine(" 4 - Quit ");
            Console.WriteLine(" ------------------------------------------------- ");


            try
            {

                string answer = Console.ReadLine();

                choice = Convert.ToInt32(answer);



                switch (choice) 
                {
                    case 1: // our first choice- input marks.

                        InputMarks();

                        break;

                    case 2:
                        OutputMarks(); // our second choice- output marks.
                        break;

                    case 3:
                        ConvertMark(); // our third choice- convert marks to grade.
                        break;
                    case 4:
                        Quit(); // our fourth choice- quits applciation.
                        break;
                }
            }

            catch (Exception)
            {
                Console.WriteLine(" Invalid number "); //if the user enters a value that isn't in our switch statement they will be met with an error.
            }


        }

        public static void InputMarks() // this is our input method- the user will enter the marks of the students.
        {
            int markInput;

            Console.WriteLine(" Please enter the student's marks ");
            Console.WriteLine(" ------------------------------------------------- ");

            for (int index = 0; index < Maxstudents; index++)
            {
                Console.Write(" Please enter a mark for " + Students[index] + " no: " + index + " : ");

                markInput = Convert.ToInt32((Console.ReadLine()));

                Marks[index] = markInput;



            }

            SelectChoice();
        }

        public static void OutputMarks() //This is our output method
        {
            Console.WriteLine(" ------------------------------------------------- ");
            Console.WriteLine(" The students have the following grades: ");

            for (int index = 0; index < Maxstudents; index++)
            {
                Console.WriteLine(Students[index] + " mark = " + Marks[index]); //This will display the students along with their respective grades.

            }

            SelectChoice();

        }

        public static void ConvertMark()// this is our convertedmark method, it'll be used to display the students marks with their grade.
        {

            for (int index = 0; index < Maxstudents; index++)

                if (Marks[index] >= 70) //if the student has recieved a mark  more than or equal to 70, they will recieve an A.
                {
                    Console.WriteLine(Students[index] + " has recieved the grade of " + Marks[index] + " A ");// displays the students name along with their marks and grade.
                }

                else if (Marks[index] >= 60)//if the student has recieved a mark  more than or equal to 60, they will recieve an B
                {
                    Console.WriteLine(Students[index] + " has recieved the grade of " + Marks[index] + " B ");
                }

                else if (Marks[index] >= 50)//if the student has recieved a mark more than or equal to 50, they will recieve an C
                {
                    Console.WriteLine(Students[index] + " has recieved the grade of " + Marks[index] + " C ");
                }

                else if (Marks[index] >= 40)//if the student has recieved a mark more than or equal to 40, they will recieve an D
                {
                    Console.WriteLine(Students[index] + " has recieved the grade of " + Marks[index] + " D ");
                }

                else if (Marks[index] < 40)//if the student has recieved a mark less than 40, they will recieve an F
                {
                    Console.WriteLine(Students[index] + " has recieved the grade of " + Marks[index] + " F ");
                }

            SelectChoice();

        }

        public static void Quit()//this is the method for the quit option

        {
            Console.Clear(); // clears the console window.
        }

    }

}



