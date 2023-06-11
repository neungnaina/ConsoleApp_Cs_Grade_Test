using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Cs_Grade_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region //Create variable
            int Num_Std = 0; //Create int of Number of Student
            string[] Name_std;//Create variable name is Name_std "Name Student" (string) array
            int[] Score_Mid, Score_Final, Score_total; //Create variable name is Score_Mid,Score_Final, Score_total array(int)
            float[] Grade; //Create variable name is Grade (float) 
            #endregion

            Console.Write("How many student ? :");//Output int text How many Student? :
            Num_Std = Convert.ToInt32(Console.ReadLine());//, You can key Number of Student ,Change String Num_Std to Int

            #region//Define array scope
            //this is ar5ray size allocation 
            Name_std = new string[Num_Std]; //Define array scope
            Score_Mid = new int[Num_Std]; // Define array scope
            Score_Final = new int[Num_Std];//Define array scope
            Score_total = new int[Num_Std];//Define array scope
            Grade = new float[Num_Std];//Define array scope
            Console.WriteLine(":: Student Information ::"); // Output :: Student Information ::
            #endregion


            {
                for (int iterator01 = 0; iterator01 < Num_Std; iterator01++) //Create loop by For loop and Create variable iterator
                {
                    Console.Write($"Please key student({iterator01 + 1} of  { Num_Std})   name :");// OutputPlease key student  Order of Student of  number of students   name :

                    Name_std[iterator01] = Console.ReadLine();  //Key Name Student  
                    Console.Write($"Please key { Name_std[iterator01]} Middle Score :");// Output "Please key Name Middle Score" :
                    Score_Mid[iterator01] = Convert.ToInt32(Console.ReadLine());// Key Score Middle ,Change String to int
                    Console.Write($"Please key {Name_std[iterator01]} Final Score :");//Please key Name student  Final Score :
                    Score_Final[iterator01] = Convert.ToInt32(Console.ReadLine());// Key Score Final ,Change String to int

                    Score_total[iterator01] = Score_Mid[iterator01] + Score_Final[iterator01];// sum of Score Middle and Score Final
                                                                                        //Console.WriteLine(Score_total[iterator]); Output Score Total
                    #region//calculate Grade Section test . Don't have loop Sample
                    //calculate Grade Section test
                    /*if (Score_total[iterator] <= 49)
                    {
                        Console.WriteLine(Name_std + "Have A Total" + Score_total + " Score or 0 Grades ");//Score Total Score Total less than or equal 49 = 0 Grades

                    }
                    else if (Score_total[iterator] <= 54)
                    {
                        Console.WriteLine(Name_std + "Have A Total" + Score_total + " Score or 1 Grades ");//Score Total Score Total less than or equal 54  = 1 Grades
                    }
                    else if (Score_total[iterator] <= 59)
                    {
                        Console.WriteLine(Name_std + "Have A Total" + Score_total + " Score or 1.5 Grades ");//Score Total Score Total less than or equal 59 = 1.5 Grades
                    }
                    else if (Score_total[iterator] <= 64)
                    {
                        Console.WriteLine(Name_std + "Have A Total" + Score_total + " Score or 2.0 Grades ");//Score Total Score Total less than or equal 64 = 2.0 Grades
                    }
                    else if (Score_total[iterator] <= 69)
                    {
                        Console.WriteLine(Name_std + "Have A Total" + Score_total + " Score or 2.5 Grades ");//Score Total Score Total less than or equal 69 = 2.5 Grades
                    }
                    else if (Score_total[iterator] <= 74)
                    {
                        Console.WriteLine(Name_std + "Have A Total" + Score_total + " Score or 3.0 Grades ");//Score Total Score Total less than or equal 74 = 3.0 Grades
                    }
                    else if (Score_total[iterator] <= 79)
                    {
                        Console.WriteLine(Name_std + "Have A Total" + Score_total + " Score or 3.5 Grades ");//Score Total Score Total less than or equal 79 = 3.5 Grades
                    }
                    else if (Score_total[iterator] >= 80)
                    {
                        Console.WriteLine(Name_std + "Have A Total" + Score_total + " Score or 4.0 Grades ");//Score Total greater than or equal to 49 = 4.0 Grades
                    }*/
                    #endregion

                }
                Console.WriteLine(":: List of Student and grade ::"); // Output ::  List of Student and grade ::
                #region  //calculate Grade Section By do while loop
                /*int iterator00 = 0; //Create variable _iterator
                do
                {
                    
                    if (Score_total[iterator00] <= 49) //Score Total less than or equal to 49 
                    {
                        Grade[iterator00] = 0.0f; //Output Grades 0.0 Grades
                    }
                    else if (Score_total[iterator00] <= 54)//Score Total less than or equal to 54  
                    {
                        Grade[iterator00] = 1.0f;//Output Grades 1.0 Grades
                    }
                    else if (Score_total[iterator00] <= 59)//Score Total less than or equal to 59 
                    {
                        Grade[iterator00] = 1.5f;//Output Grades 1.5 Grades
                    }
                    else if (Score_total[iterator00] <= 64)//Score Total less than or equal to 64  
                    {
                        Grade[iterator00] = 2.0f;//Output Grades 2.0 Grades
                    }
                    else if (Score_total[iterator00] <= 69)//Score Total less than or equal to 69  
                    {
                        Grade[iterator00] = 2.5f;//Output Grades 2.5 Grades
                    }
                    else if (Score_total[iterator00] <= 74)//Score Total less than or equal to 74 
                    {
                        Grade[iterator00] = 3.0f;//Output Grades 3.0 Grades
                    }
                    else if (Score_total[iterator00] <= 79)//Score Total less than or equal to 79  
                    {
                        Grade[iterator00] = 3.5f;//Output Grades 3.5 Grades
                    }
                    else if (Score_total[iterator00] >= 80)//Score Total greater than or equal to 80 
                    {
                        Grade[iterator00] = 4.0f;//Output Grades 4.0 Grades 
                    }
                    Console.WriteLine($"{iterator00+1}. {Name_std[iterator00]} " +
                        $" have a total {Score_total[iterator00]} score or {Grade[iterator00]} grade.");// Output No. 1 2 3 ... (up to Number of Student)
                                                                                                      // +have a total Score ... or Grade
                    iterator00++; // variable _iterator+1 
                }
                while (iterator00 < Num_Std); // variable < Number of student = stop*/
                #endregion
                #region  //calculate Grade Section By while loop
                int iterator02 = 0; //Create variable iterator
                while ( iterator02 < Num_Std ) 
                {
                    if (Score_total[iterator02] <= 49) //Score Total less than or equal to 49 
                    {
                        Grade[iterator02] = 0.0f; //Output Grades 0.0 Grades
                    }
                    else if (Score_total[iterator02] <= 54)//Score Total less than or equal to 54  
                    {
                        Grade[iterator02] = 1.0f;//Output Grades 1.0 Grades
                    }
                    else if (Score_total[iterator02] <= 59)//Score Total less than or equal to 59 
                    {
                        Grade[iterator02] = 1.5f;//Output Grades 1.5 Grades
                    }
                    else if (Score_total[iterator02] <= 64)//Score Total less than or equal to 64  
                    {
                        Grade[iterator02] = 2.0f;//Output Grades 2.0 Grades
                    }
                    else if (Score_total[iterator02] <= 69)//Score Total less than or equal to 69  
                    {
                        Grade[iterator02] = 2.5f;//Output Grades 2.5 Grades
                    }
                    else if (Score_total[iterator02] <= 74)//Score Total less than or equal to 74 
                    {
                        Grade[iterator02] = 3.0f;//Output Grades 3.0 Grades
                    }
                    else if (Score_total[iterator02] <= 79)//Score Total less than or equal to 79  
                    {
                        Grade[iterator02] = 3.5f;//Output Grades 3.5 Grades
                    }
                    else if (Score_total[iterator02] >= 80)//Score Total greater than or equal to 80 
                    {
                        Grade[iterator02] = 4.0f;//Output Grades 4.0 Grades 
                    }
                    Console.WriteLine($"{iterator02 + 1}. {Name_std[iterator02]} " +
                        $" have a total {Score_total[iterator02]} score or {Grade[iterator02]} grade.");// Output No. 1 2 3 ... (up to Number of Student)
                                                                                                        // +have a total Score ... or Grade
                    iterator02++; // variable _iterator+1
                }
                #endregion
                #region  //calculate Grade Section By foreach loop
                /*int iterator03 = 0;
                foreach (string iterator04 in Name_std)
                {
                    if (Score_total[iterator03] <= 49) //Score Total less than or equal to 49 
                    {
                        Grade[iterator03] = 0.0f; //Output Grades 0.0 Grades
                    }
                    else if (Score_total[iterator03] <= 54)//Score Total less than or equal to 54  
                    {
                        Grade[iterator03] = 1.0f;//Output Grades 1.0 Grades
                    }
                    else if (Score_total[iterator03] <= 59)//Score Total less than or equal to 59 
                    {
                        Grade[iterator03] = 1.5f;//Output Grades 1.5 Grades
                    }
                    else if (Score_total[iterator03] <= 64)//Score Total less than or equal to 64  
                    {
                        Grade[iterator03] = 2.0f;//Output Grades 2.0 Grades
                    }
                    else if (Score_total[iterator03] <= 69)//Score Total less than or equal to 69  
                    {
                        Grade[iterator03] = 2.5f;//Output Grades 2.5 Grades
                    }
                    else if (Score_total[iterator03] <= 74)//Score Total less than or equal to 74 
                    {
                        Grade[iterator03] = 3.0f;//Output Grades 3.0 Grades
                    }
                    else if (Score_total[iterator03] <= 79)//Score Total less than or equal to 79  
                    {
                        Grade[iterator03] = 3.5f;//Output Grades 3.5 Grades
                    }
                    else if (Score_total[iterator03] >= 80)//Score Total greater than or equal to 80 
                    {
                        Grade[iterator03] = 4.0f;//Output Grades 4.0 Grades 
                    }
                    Console.WriteLine($"{iterator03 + 1}. {Name_std[iterator03]} " +
                        $" have a total {Score_total[iterator03]} score or {Grade[iterator03]} grade.");// Output No. 1 2 3 ... (up to Number of Student)
                                                                                                        // +have a total Score ... or Grade
                    iterator03++; // variable _iterator+1
                }*/
                #endregion

                Console.Write("\nPress any key enter....");

                Console.ReadKey();// press for close Program




            }
            


        }
    }
}
