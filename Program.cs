using System;
using System.IO;
using System.Linq;

namespace Preparatory_Test
{
    class Program
    {
        private bool IsTextChanged;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.IsPalindrome();
        }

        // Returns Hello World to user
        public void HelloWorld()
        {
            Console.WriteLine("Hello World");
            Console.Read();

        }

        // Takes the users info and returns the info in one sentence.
        public void UserInfo()
        {
            Console.WriteLine("Type your firstname:\n");
            string firstname = Console.ReadLine();

            Console.WriteLine("Type your surname:\n");
            string surname = Console.ReadLine();

            Console.WriteLine("How old are you?\n");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your name is {firstname} {surname} and you are {age} years old");
            Console.Read();
        }

        // Changes the console text to green when called
        // If method is called again then it switches back
        // to white text.
        public void ChangeConsoleText()
        {
            if (!IsTextChanged)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                IsTextChanged = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                IsTextChanged = false;
            }
        }

        // Returns current date
        public void CurrentDate()
        {
            Console.WriteLine(DateTime.Now);
            Console.Read();
        }

        // Returns users highest input
        public void ReturnHighestNumber()
        {
            Console.WriteLine("Type a number");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type a number");
            int inputTwo = Convert.ToInt32(Console.ReadLine());

            if (inputOne > inputTwo)
                Console.WriteLine(inputOne);
            else
                Console.WriteLine(inputTwo);

            Console.Read();
        }

        // Generates a random number between 1-100
        // which the user should guess.
        // If the users guessed right then it will tell how
        // many times the user guessed before getting it right.
        public void GuessTheNumber()
        {
            var rnd = new Random();
            int randomNumber = rnd.Next(1, 101);
            int amountOfTries = 1;
            int input;

            Console.WriteLine("Guess the number, type a number between 1-100");
            do
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (input != randomNumber)
                {
                    amountOfTries++;
                    if (input > randomNumber)
                        Console.WriteLine("Wrong! Guess lower");
                    else
                        Console.WriteLine("Wrong! Guess higher");
                }

            } while (randomNumber != input);

            Console.WriteLine($"You guessed right! The right answer is {randomNumber} and you guessed {input}. It took {amountOfTries} tries");
            Console.Read();
        }

        // Saves the user input in a text file in the users documents folder.
        public void SaveTextToFile()
        {
            Console.WriteLine("Type something to save it into your harddrive");

            // Saves the file in My Documents folder as UserInput.txt.
            File.WriteAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\UserInput.txt", Console.ReadLine());

            Console.WriteLine($"You have now saved the text in Userinput.txt file which can be found at {Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}");
            Console.Read();
        }

        // Read the text file created from the method SaveTextToFile()
        public void ReadTextFile()
        {
            // Return which text file is being read.
            Console.WriteLine($"Current text in {Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\UserInput.txt");
            // Returns the content from the textfile.
            Console.WriteLine(File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\UserInput.txt"));
            Console.Read();
        }

        // Calculates and returns 3 different values of the users input
        public void CalculateUserInput()
        {
            Console.WriteLine("Type a decimal number");
            var userInput = Convert.ToDouble(Console.ReadLine());

            // Square root of user input
            Console.WriteLine("Square Root: " + Math.Sqrt(Convert.ToDouble(userInput)));
            // User input square 2
            Console.WriteLine(userInput + "^2: " + Math.Pow(userInput, 2));
            // User input square 10
            Console.WriteLine(userInput + "^10: " + Math.Pow(userInput, 10));
            Console.Read();
        }

        // Writes Multiplication Table from 1-10
        public void WriteMultiplicationTable()
        {
            // First for-loop determines which multiplication
            // table to be used (e.g 1x1, 2x1 or 9x1 etc.)
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"\n{i}s Multiplications Table");

                for (int j = 1; j <= 10; j++)
                {
                    // Second for-loop determines the number to multiply
                    // with the table we're using (e.g if we're using number one multiplication table
                    // it will change to 1x3, 1x5 or 1x9)
                    Console.Write($"{i}*{j}={i * j}\t");
                }
                Console.WriteLine();
            }
            Console.Read();
        }

        // Creates two arrays with random numbers where one is sorted and the other is not.
        public void CreateTwoArrays()
        {
            var rnd = new Random();

            int[] arrayOne = new int[rnd.Next(1, 101)];
            int[] arrayTwo = new int[arrayOne.Length];

            for (int i = 0; i < arrayOne.Length; i++)
            {
                // Sets current index with random created number.
                arrayOne[i] = rnd.Next(1, 101);
            }

            // Copies first array into second array.
            Array.Copy(arrayOne, arrayTwo, arrayOne.Length);
            // Sorts the second array
            Array.Sort(arrayTwo);

        }

        // Checks if input is a palindrome
        public bool IsPalindrome()
        {
            Console.WriteLine("Enter a Palindrome");
            var input = Console.ReadLine().ToLower();
            // Reverses the input into char array
            var charArray = input.Reverse();
            // Creates new string with the reversed char array
            var reversed = new string(charArray.ToArray());

            if (input == reversed)
                return true;

            return false;
        }

        public void ReturnInputNumbers()
        {
            Console.WriteLine("Type a number");
            var inputOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type a new number");
            var inputTwo = Convert.ToInt32(Console.ReadLine());

            // Skriv ut alla siffror mellan input 1 och 2.

        }


    }
}
