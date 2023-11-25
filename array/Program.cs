using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Array
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int rows, columns;
            Console.WriteLine("HI, this is a program, that works with 2D arrays");
            Console.WriteLine("enter size of the row");
            rows = int.Parse(Console.ReadLine());  //reads your input as integer
            Console.WriteLine("enter size of the column");
            columns = int.Parse(Console.ReadLine());
            int[,] array = new int[rows, columns]; //new array

            Console.WriteLine("for random fill enter 1:");
            Console.WriteLine("for gradual fill enter 2");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    array = Random(array);
                    break;
                case 2:
                    array = gradual(array);
                    break;
            }
            while (true)
            {
                Console.WriteLine("Select an operation:");
                Console.WriteLine("1. Swap Rows");
                Console.WriteLine("2. Swap Columns");
                Console.WriteLine("3. Transposition");
                Console.WriteLine("4. scalar Multiplication");
                Console.WriteLine("5. swap numbers on diagonal ");
                Console.WriteLine("6.swap numbers on second diagonal");
                Console.WriteLine("7.variable switch");
                Console.WriteLine("8.array addition");
                Console.WriteLine("9.array substraction");

                int operationChoice = int.Parse(Console.ReadLine());
                int[,] array2; //define array2 as an 2D array
                switch (operationChoice)
                {
                    case 1:
                        array = SwapRow(array);  // by assigning the result back to array, we can keep the updated result, same goes for all the cases below
                        break;

                    case 2:
                        array = SwapColumn(array);
                        break;

                    case 3:
                        array = transposition(array);
                        break;

                    case 4:
                        array = multiplication(array);
                        break;

                    case 5:
                        array = diagonalswap(array);
                        break;

                    case 6:
                        array = seconddiagonalswap(array);
                        break;
                    case 7:
                        array = variableswitch(array);
                        break;
                    case 8:
                        Console.WriteLine("Enter the second array:");
                        array2 = ControlArrayInput(array);//the array we are adding 
                        array = ArrayAddition(array, array2); //we know we are working with an 2Darray
                        break;
                    case 9:
                        Console.WriteLine("Enter the second array:");
                        array2 = ControlArrayInput(array); //the array we are substracting
                        ArraySubtraction(array, array2);
                        break;
                    default:
                        Console.WriteLine("Invalid operation choice");
                        break;
                }
                Console.Write("DO you wanna continue working with the same array? (yes/no): "); // repeating the cycle if you wanna work with the same array , otherwise it stops debugging
                string response = Console.ReadLine();
                if (response.ToLower() != "yes")
                {
                    Console.WriteLine("program ended");
                }
                Console.ReadKey();
            }
        }
        static int[,] Random(int[,] array) //we need this instead of static void, beacuse it doesnt return any result and we couldnt keep the updated array
        {                                           // updated array = array we already worked with
            int rows = array.GetLength(0); //size of the row
            int columns = array.GetLength(1); //size of the column
            Random random = new Random();
            for (int i = 0; i < rows; i++) //the cycle wont stop until all variables in the row are assigned with a number
            {
                for (int j = 0; j < columns; j++) //same thing just with columns
                {
                    array[i, j] = random.Next(1, 101); // Generates a random number between 1 and 100
                    Console.Write(array[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            return array; // Return the updated array
        }
        static int[,] gradual(int[,] array)
        {
            int counter = 0; //integer variable that we will add to something
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = ++counter;
                    Console.Write($"{array[i, j]} ");
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            return array;
        }
        static int[,] SwapRow(int[,] array)
        {
            int numRows = array.GetLength(0);
            Console.WriteLine("Enter the first row number to swap:");
            int nRowSwap, mRowSwap;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out nRowSwap) && nRowSwap >= 0 && nRowSwap < numRows) //checks if the nRow number is within the amount of ->
                {                                                                                          //-> Rows in the array and that it must be greater than zero, if all good program proceeds
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid row number.");
                }
            }
            Console.WriteLine("Enter the second row number to swap:");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out mRowSwap) && mRowSwap >= 0 && mRowSwap < numRows) //same thing as above
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid row number.");
                }
            }
            for (int j = 0; j < array.GetLength(1); j++)
            {
                int temp = array[nRowSwap, j]; //"captures" current value at a certain position
                array[nRowSwap, j] = array[mRowSwap, j]; //swaps 
                array[mRowSwap, j] = temp; //assigns new value
            }
            arrayprint(array);
            return array;
        }
        static int[,] SwapColumn(int[,] array)
        {
            int numCols = array.GetLength(0);
            Console.WriteLine("Enter the first column number to swap:");
            int nColSwap, mColSwap;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out nColSwap) && nColSwap >= 0 && nColSwap < numCols) //same thing as with the rows
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid row number.");
                }
            }
            Console.WriteLine("Enter the second column number to swap:");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out mColSwap) && mColSwap >= 0 && mColSwap < numCols)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid row number.");
                }
            }
            for (int i = 0; i < array.GetLength(1); i++)
            {
                int temp = array[i, nColSwap];
                array[i, nColSwap] = array[i, mColSwap];
                array[i, mColSwap] = temp;
            }
            arrayprint(array);
            return array;
        }
        static int[,] transposition(int[,] array)
        {
            int[,] transposedArray = new int[array.GetLength(1), array.GetLength(0)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    transposedArray[j, i] = array[i, j]; //basically switches every single variable on row/column with its counterpart 
                }
            }
            arrayprint(transposedArray); //calling a method for printing array, by adding : (transposedArray), we specify what array we are printing
            return transposedArray; //returning back transposed array
        }
        static int[,] multiplication(int[,] array)
        {
            Console.WriteLine("Enter the scalar to multiply the array by:");
            if (int.TryParse(Console.ReadLine(), out int scalar))
            {
                int[,] result = MultiplyByScalar(array, scalar); //array = input array, scalar = number by which we multibly the array
                Console.WriteLine($"Array multiplied by {scalar}:");
                arrayprint(result); //function at the bottom prints the new mutliplied array
                return result; //returns updated array
            }
            else
            {
                Console.WriteLine("Invalid input for the scalar.");
                return array;//return the original array
            }
            int[,] MultiplyByScalar(int[,] inputArray, int inputScalar)
            {
                int rows = inputArray.GetLength(0);
                int columns = inputArray.GetLength(1);

                int[,] resultArray = new int[rows, columns];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        resultArray[i, j] = inputArray[i, j] * inputScalar; //here it gets multiplied
                    }
                }
                arrayprint(array);
                return resultArray;
            }
        }
        static int[,] diagonalswap(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0) / 2; i++) //only half of the rows, so we dont swap them back
            {
                int temp = array[i, i]; //on diagonal, column and row index are the same
                int coordToSwap = array.GetLength(0) - 1 - i; //size of the row - 1- the index of the coord we are on
                array[i, i] = array[coordToSwap, coordToSwap];
                array[coordToSwap, coordToSwap] = temp;
            }
            arrayprint(array);
            return array;
        }
        static int[,] seconddiagonalswap(int[,] array)
        {
            for (int i = array.GetLength(0) - 1; i > array.GetLength(0) / 2; i--)
            {
                int j = array.GetLength(0) - 1 - i;
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
            arrayprint(array);
            return array;
        }
        static int[,] variableswitch(int[,] array)
        {
            Console.WriteLine("input final destination coordinates  of the first valuable in [x,y] order:");
            int.TryParse(Console.ReadLine(), out int xFirst);
            int.TryParse(Console.ReadLine(), out int yFirst);

            Console.WriteLine("input final destination coordinates of the second valuable in [x,y] order:");
            int.TryParse(Console.ReadLine(), out int xSecond);
            int.TryParse(Console.ReadLine(), out int ySecond);

            int temporary = array[xFirst, yFirst];
            array[xFirst, yFirst] = array[xSecond, ySecond];
            array[xSecond, ySecond] = temporary;
            arrayprint(array);
            return array;
        }
        static int[,] ArrayAddition(int[,] array, int[,] array2)
        {
            int[,] result = Addition(array, array2);

            Console.WriteLine("Original Array + New Array:");
            arrayprint(result);
            return result;
        }
        static int[,] Addition(int[,] inputArray, int[,] inputArray2)
        {
            int rows = inputArray.GetLength(0);
            int columns = inputArray.GetLength(1);

            int[,] resultArray = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    resultArray[i, j] = inputArray[i, j] + inputArray2[i, j];
                }
            }
            return resultArray;
        }
        static int[,] ArraySubtraction(int[,] array, int[,] array2)
        {
            int[,] result = Subtraction(array, array2);

            Console.WriteLine("Original Array - New Array:");
            arrayprint(result);
            return result;
        }
        static int[,] Subtraction(int[,] array, int[,] array2)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            int[,] resultArray = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    resultArray[i, j] = array[i, j] - array2[i, j];
                }
            }
            return resultArray;
        }
        static int[,] arrayprint(int[,] array) //method so i dont have to everytime write the code for printing the array
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            return array;
        }
        static int[,] ControlArrayInput(int[,] array) //this method creates the arra2 that we use to add or substract
        {

            while (true)
            {
                Console.WriteLine($"Enter the size of the row for the new array (must be the same as the first array ):");
                int rows2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the size of the column for the new array (must be the same as the first array):");
                int columns2 = int.Parse(Console.ReadLine());

                if (rows2 == array.GetLength(0) && columns2 == array.GetLength(1)) //checks if they are the same size,
                {                                                                  //because you CANNOT add or substract arrays that are not the same size
                    int[,] newArray = new int[rows2, columns2];

                    Console.WriteLine("For random fill enter 1:");
                    Console.WriteLine("For gradual fill enter 2");
                    Console.WriteLine("For manual entry enter 3");

                    int choice2 = int.Parse(Console.ReadLine());

                    switch (choice2)
                    {
                        case 1:
                            newArray = Random(newArray);
                            break;
                        case 2:
                            newArray = gradual(newArray);
                            break;
                        case 3:
                            Console.WriteLine("Enter the elements for the new array:");
                            for (int i = 0; i < rows2; i++)
                            {
                                for (int j = 0; j < columns2; j++)
                                {
                                    Console.Write($"Enter element at position [{i}, {j}]: "); //here we can choose the array, not very good when we have a big array
                                    newArray[i, j] = int.Parse(Console.ReadLine());           // then we need too add for example array[20,20] we need to write 400 numbers
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid choice"); // Exit the program if the choice is not 1, 2, or 3
                            break;
                    }
                    return newArray;
                }
                else
                {
                    Console.WriteLine("The dimensions of the new array must be the same as the first array. Please try again.");
                }
            }
        }
    }
}




