using System;
using System.Globalization;
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



            bool exit = true;

            do
            {
                Console.Clear();

                Console.WriteLine("Type the number of your menu selection and hit enter:");
                Console.WriteLine("1: Hello world");
                Console.WriteLine("2: Enter user info");
                Console.WriteLine("3: Change console text to green, enter the selection again to change back");
                Console.WriteLine("4: Show current date");
                Console.WriteLine("5: Return highest entered number");
                Console.WriteLine("6: Guess the number");
                Console.WriteLine("7: Save file");
                Console.WriteLine("8: Read file");
                Console.WriteLine("9: Calculates the square root, square 2 and square 10 of your input");
                Console.WriteLine("10: Multiplication Table");
                Console.WriteLine("11: Create two arrays");
                Console.WriteLine("12: Enter a palindrome word");
                Console.WriteLine("13: Check the numbers between two inputs");
                Console.WriteLine("14: Sort your numbers between odd and even numbers");
                Console.WriteLine("15: Sum your input");
                Console.WriteLine("16: Set your character name and the enemy character name");
                Console.WriteLine("0: Enter 0 to exit\n");

                switch (Convert.ToInt32(Console.ReadLine()))
                {

                    case 1:
                        Console.Clear();
                        p.HelloWorld();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        p.UserInfo();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        p.ChangeConsoleText();
                        Console.WriteLine("Press any key to return to the menu");
                        break;
                    case 4:
                        Console.Clear();
                        p.CurrentDate();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        p.ReturnHighestNumber();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        p.GuessTheNumber();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        p.SaveTextToFile();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                        p.ReadTextFile();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();
                        p.CalculateUserInput();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 10:
                        Console.Clear();
                        p.WriteMultiplicationTable();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 11:
                        Console.Clear();
                        p.CreateTwoArrays();
                        Console.WriteLine("\nPress any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 12:
                        Console.Clear();
                        p.IsPalindrome();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 13:
                        Console.Clear();
                        p.ReturnNumbersInbetweenInputs();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 14:
                        Console.Clear();
                        p.SortOddAndEvenNumbers();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 15:
                        Console.Clear();
                        p.AddInputValues();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 16:
                        Console.Clear();
                        p.SetCharacterNames();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 0:
                        exit = false;
                        break;

                    default:
                        break;
                }
            } while (exit);
        }

        /// <summary>
        /// 1. Returns Hello World to user
        /// </summary>
        public void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        /// <summary>
        /// 2. Takes the users info and returns the info in one sentence.
        /// </summary>
        public void UserInfo()
        {
            Console.WriteLine("Type your firstname:");
            string firstname = Console.ReadLine();

            Console.WriteLine("Type your surname:");
            string surname = Console.ReadLine();

            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nYour name is {firstname} {surname} and you are {age} years old");
        }

        /// <summary>
        /// 3. Changes the console text to green and switches back if called again
        /// </summary>
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

        /// <summary>
        /// 4. Writes current date
        /// </summary>
        public void CurrentDate()
        {
            Console.WriteLine(DateTime.Now);
        }

        /// <summary>
        /// 5. Writes users highest input
        /// </summary>
        public void ReturnHighestNumber()
        {
            Console.WriteLine("Type a number");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type a number");
            int inputTwo = Convert.ToInt32(Console.ReadLine());

            if (inputOne > inputTwo)
                Console.WriteLine("Highest number\n" + inputOne);
            else
                Console.WriteLine("Highest number\n" + inputTwo);
        }

        /// <summary>
        /// 6. Generates a random number between 1-100
        /// which the user should guess.
        /// If the users guessed right then it will tell how
        /// many times the user guessed before getting it right.
        /// </summary>
        public void GuessTheNumber()
        {
            var rnd = new Random();
            int randomNumber = rnd.Next(1, 101);
            int amountOfTries = 1;
            int input;

            Console.WriteLine("Guess the number, type a number between 1-100");
            // do-while loop if random number does not match input
            do
            {
                input = Convert.ToInt32(Console.ReadLine());

                if (input != randomNumber)
                {
                    // Incrementing amount of user tries
                    amountOfTries++;

                    // Checks if the user input is higher or lower than
                    // the random generated number
                    if (input > randomNumber)
                        // Tells the user to guess lower
                        Console.WriteLine("Wrong! Guess lower");
                    else
                        // Tells the user to guess higher
                        Console.WriteLine("Wrong! Guess higher");
                }

            } while (randomNumber != input);

            // Writes this when the user answered right
            Console.WriteLine($"You guessed right! The right answer is {randomNumber} and you guessed {input}. It took {amountOfTries} tries");
        }

        /// <summary>
        /// 7. Saves the user input in a text file in the users documents folder.
        /// </summary>
        public void SaveTextToFile()
        {
            Console.WriteLine("Type something to save it into your harddrive");

            // Saves the file in My Documents folder as UserInput.txt.
            File.WriteAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\UserInput.txt", Console.ReadLine());

            Console.WriteLine($"You have now saved the text in Userinput.txt file which can be found at {Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}");
        }

        /// <summary>
        /// 8. Read the text file created from the method SaveTextToFile()
        /// </summary>
        public void ReadTextFile()
        {
            // Return which text file is being read.
            Console.WriteLine($"Current text in {Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\UserInput.txt");
            // Returns the content from the textfile.
            Console.WriteLine(File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\UserInput.txt"));
        }

        /// <summary>
        /// 9. Calculates and returns 3 different values of the users input
        /// </summary>
        public void CalculateUserInput()
        {
            Console.WriteLine("Type a decimal number");
            var userInput = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Square root of user input
            Console.WriteLine("Square Root: " + Math.Sqrt(Convert.ToDouble(userInput)));
            // User input square 2
            Console.WriteLine(userInput + "^2: " + Math.Pow(userInput, 2));
            // User input square 10
            Console.WriteLine(userInput + "^10: " + Math.Pow(userInput, 10));
        }

        /// <summary>
        /// 10. Writes Multiplication Table from 1-10
        /// </summary>
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
        }

        /// <summary>
        /// 11. Creates two arrays with random numbers where one is sorted and the other is not.
        /// </summary>
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

            Console.WriteLine("\nRandom generated numbers in array:\n");
            foreach (var num in arrayOne)
            {
                Console.Write($"{num}\t");
            }

            Console.WriteLine("\nSorted numbers from other array:\n");
            foreach (var num in arrayTwo)
            {
                Console.Write($"{num}\t");
            }
        }

        /// <summary>
        /// 12. Checks if input is a palindrome
        /// </summary>
        /// <returns>True if a palindrome</returns>
        public void IsPalindrome()
        {
            Console.WriteLine("Enter a Palindrome");
            var input = Console.ReadLine().ToLower();
            // Reverses the input into char array
            var charArray = input.Reverse();
            // Creates new string with the reversed char array
            var reversed = new string(charArray.ToArray());

            if (input == reversed)
            {
                Console.WriteLine("Your word is a palindrome: " + reversed);
            }
            else
                Console.WriteLine("Your word is not a palindome, reversed word: " + reversed);
        }

        /// <summary>
        /// 13. Function that takes two inputs and returns the values between the two inputs. Starting from the lowest one
        /// </summary>
        public void ReturnNumbersInbetweenInputs()
        {
            Console.WriteLine("Type a number");
            var inputOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type a second number");
            var inputTwo = Convert.ToInt32(Console.ReadLine());
            int difference;

            // Checks if input 1 is higher than input 1
            // To return value from lowest number
            if (inputOne > inputTwo)
            {
                Console.WriteLine($"Numbers between {inputTwo} and {inputOne}");

                // Checks the difference between the inputs
                // to use as loop condition
                difference = inputOne - inputTwo;

                for (int i = 0; i < difference; i++)
                {
                    inputTwo++;
                    // Writes an increment of input 2 
                    // because it's the lowest number
                    Console.Write($"{inputTwo}\t");
                }
            }
            else
            {
                Console.WriteLine($"Numbers between {inputOne} and {inputTwo}");

                // Checks the difference between the inputs
                // to use as loop condition
                difference = inputTwo - inputOne;

                for (int i = 0; i < difference; i++)
                {
                    inputOne++;
                    // Writes an increment of input 2 
                    // because it's the lowest number
                    Console.Write($"{inputOne}\t");
                }
            }
        }

        /// <summary>
        /// 14. Splits and returns the input value between odd and even numbers
        /// </summary>
        public void SortOddAndEvenNumbers()
        {
            Console.WriteLine("Enter a few numbers separated by comma");
            var input = Console.ReadLine();

            // Splits the input at commas
            var inputSplitted = input.Split(',');

            Console.WriteLine("Even Numbers");

            // Loop through the numbers
            foreach (var evenNumber in inputSplitted)
            {
                // Check if the number is divided by 2
                if (Convert.ToInt32(evenNumber) % 2 == 0)
                    // Writes the even numbers
                    Console.Write(evenNumber.Trim() + "\t");
            }

            Console.WriteLine("\nOdd numbers");
            foreach (var oddNumber in inputSplitted)
            {
                // Check if the number is not divided by 2
                if (Convert.ToInt32(oddNumber) % 2 == 1)
                    // Writes the odd numbers
                    Console.Write(oddNumber.Trim() + "\t");
            }
        }

        /// <summary>
        /// 15. Adds the user inputs and returns the sum
        /// </summary>
        public void AddInputValues()
        {
            Console.WriteLine("Enter a few numbers separated by comma");
            var input = Console.ReadLine();
            // Splits the input at commas and trims it from whitespaces
            var inputSplitted = input.Trim().Split(',');

            // Converts the input array to int array
            var intArray = Array.ConvertAll(inputSplitted, int.Parse);

            // Writes the sum of the int array
            Console.WriteLine(intArray.Sum());
        }

        /// <summary>
        /// 16. User sets the name of his and the enemy character. Health, strength and luck is random generated.
        /// </summary>
        public void SetCharacterNames()
        {
            // User and Enemy character instances
            var userCharacter = new Character();
            var enemyCharacter = new Character();

            Random rnd = new Random();
            int minValue = 1;
            int maxValue = 101;

            Console.WriteLine("Enter a name for your character");
            // Sets the name for the user character
            userCharacter.Name = Console.ReadLine();
            Console.WriteLine("Enter a name for the enemy character");
            // Sets the name for the enemy character
            enemyCharacter.Name = Console.ReadLine();

            // Random generated values for enemy health, strength and luck
            enemyCharacter.Health = rnd.Next(minValue, maxValue);
            enemyCharacter.Strength = rnd.Next(minValue, maxValue);
            enemyCharacter.Luck = rnd.Next(minValue, maxValue);

            // Random generated values for user health, strength and luck
            userCharacter.Health = rnd.Next(minValue, maxValue);
            userCharacter.Strength = rnd.Next(minValue, maxValue);
            userCharacter.Luck = rnd.Next(minValue, maxValue);

            Console.WriteLine($"\nYour character name: {userCharacter.Name} \nHealth: {userCharacter.Health}\nStrength: {userCharacter.Strength}\nLuck: {userCharacter.Luck}");
            Console.WriteLine($"\nYour character name: {enemyCharacter.Name} \nHealth: {enemyCharacter.Health}\nStrength: {enemyCharacter.Strength}\nLuck: {enemyCharacter.Luck}");

        }
    }
}
