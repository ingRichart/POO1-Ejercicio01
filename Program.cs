// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//     /*
//     Realiza una función o método que reciba un arreglo y regresa la mayor diferencia entre cualquier par de números, independientemente de su posición.
//     Ejemplo:

//     mayorDiferencia( [ 1, 1, 4 ]) // 3
//     mayorDiferencia( [ 9, 8 ]) // 1
//     mayorDiferencia( [ 6, 22, 16, 29, 23 ]) // 23
//     mayorDiferencia( [ 28, 16, 28, 11, 14, 26, 23, 25, 17, 3, 22, 23, 23, 10 ]) // 25
//     */

//     int[] arrays = [ 1, 1, 4 ];

//     List<int> result = new List<int>();
//     int value; 

//     for (int i = 0; i < arrays.Length; i++)
//     {
//         for (int j = 0; j < arrays.Length; j++)
//         {
//             value = arrays[i] - arrays[j];
//             result.Add(value);
//         }
//     }

//     Console.WriteLine(result.Max());


// Declare variables and then initialize to zero.
    int num1 = 0; int num2 = 0;

    // Display title as the C# console calculator app.
    Console.WriteLine("Console Calculator in C#\r");
    Console.WriteLine("------------------------\n");

    // Ask the user to type the first number.
    Console.WriteLine("Type a number, and then press Enter");
    num1 = Convert.ToInt32(Console.ReadLine());

    // Ask the user to type the second number.
    Console.WriteLine("Type another number, and then press Enter");
    num2 = Convert.ToInt32(Console.ReadLine());

    // Ask the user to choose an option.
    Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine("\ta - Add");
    Console.WriteLine("\ts - Subtract");
    Console.WriteLine("\tm - Multiply");
    Console.WriteLine("\td - Divide");
    Console.Write("Your option? ");

    // Use a switch statement to do the math.
    switch (Console.ReadLine())
    {
        case "a":
            Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
            break;
        case "s":
            Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
            break;
        case "m":
            Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
            break;
        case "d":
            Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
            break;
    }
    // Wait for the user to respond before closing.
    Console.Write("Press any key to close the Calculator console app...");
    Console.ReadKey();