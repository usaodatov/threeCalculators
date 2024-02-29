using System;


namespace threeCalculators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Discription:
            Console.WriteLine(@"--------------------------------------------------------------------------------------------------

A simple calculator app. Build by UMID SAODATOV for CTF 3201 - 2024

It uses 'while' loops, 'if' statements, and a 'do-while' loop. 

'While' loops are used to keep asking for numbers and the math 
operation (like +, -, *, /) until we get something that makes sense.

The 'if' statements help decide what to do with the numbers - like adding or subtracting them. 

The 'do-while' loop means the calculator keeps going, asking if you want to do another calculation, 
until you say no.

So, all these parts work together to make sure the calculator only gets the right inputs, 
does the math correctly, and can do it over and over if you want.

--------------------------------------------------------------------------------------------------");
            
            //initialise the app
            Console.ReadLine(); 
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();



            bool redoCalc = true; //activate redo loop => bool(true) + do + while method
            do
        {
            //welcome message:
            Console.WriteLine("---------------------------");
            Console.WriteLine("Calculator CTF 3201 - 2024 ");
            Console.WriteLine("  press ENTER to continue  ");
            Console.WriteLine("---------------------------");
            Console.ReadLine();
            
            //User input:
            
            //Input ONE
           float resultOne; //activate univeral storage for input1

            while (true) // loop to allow retry
            {
                
                Console.Write("First Number please:  ");
                string userenteryOne = Console.ReadLine();   //input from user and its stored    


                //test if input converts to FLOAT
                bool valueOne = float.TryParse(userenteryOne, out resultOne);

                if (valueOne == true)
                {
                    break; //exit loop
                }
                else
                {
                    Console.WriteLine("Invalid input, Enter Numbers only, use [,] to separate decimals");
                }
            }

                //Input Operator
                Console.Write("\nOperator please :  [    +   -    *    /     ]    -> ");
                string userenteryOperator = Console.ReadLine();   //input from user and its stored

                while (true) // loop to allow retry
                {
                    if (userenteryOperator == "+" || userenteryOperator == "-" || userenteryOperator == "*" || userenteryOperator == "/")
                    {
                        break; //exit loop
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input, Enter +, -, *, / only");
                        Console.Write("\nOperator please  :  [    +   -    *    /     ]    -> ");
                        userenteryOperator = Console.ReadLine();   //input from user and its stored
                    }
                }
             


                //Input Two
                float resultTwo; //activate univeral storage for input1

             while (true) // loop to allow retry
                {
                    Console.Write("\nSecond Number please:  ");
                    string userenteryTwo = Console.ReadLine();   //input from user and its stored    


                    //test if input converts to FLOAT
                    bool valueTwo = float.TryParse(userenteryTwo, out resultTwo);

                    if (valueTwo == true)
                    {
                        break; //exit loop
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, Enter Numbers only, use [,] to separate decimals");
                    }

                }
             

             
                
            float result = 0; //activate univeral FLOAT storage for result

            //IF statements to calculate - store under float result

            if (userenteryOperator == "+")
            {
                result = resultOne + resultTwo;
            }
            else if (userenteryOperator == "-")
            {
                result = resultOne - resultTwo;
            }
            else if (userenteryOperator == "*")
            {
                result = resultOne * resultTwo;
            }
            else if (userenteryOperator == "/")
                    if (resultTwo == 0)                  //test if inputTwo is zero - on devision only / avoid error
                    {
                        Console.WriteLine("\nInvalid input, cannot divide by zero");
                        Console.WriteLine("\nPlease try again - Press ENTER to go back!");
                        Console.ReadLine();
                        Console.Clear();
                        continue;

                    }
                    else
            {
                result = resultOne / resultTwo;
            }
           


            //Output
            Console.WriteLine("\n-------------------------------------------------");
            Console.WriteLine("\nThe calculation was:  " + resultOne + " " + userenteryOperator + " " + resultTwo);
            Console.WriteLine("\nThe result of the calculation :  " + result);

                //redo loop - request instructions
            Console.Write("\nWould you like to performa another calculation?: yes/no   ->  " );
            string lastwish = Console.ReadLine().ToLower();
            
            // if 'yes' then redo, if 'not' then goodbye and exit    
            if (lastwish == "yes")
            {
                    redoCalc = true; //activate redo loop
                    
         
            }
            else
            {
                redoCalc = false; //deactivate redo loop
                Console.WriteLine(" \nThe End!\n - \nGoodbye! ");
                Console.ReadLine();
                
            }
            } while (redoCalc);
            Console.ReadLine();

            }

    }
}
