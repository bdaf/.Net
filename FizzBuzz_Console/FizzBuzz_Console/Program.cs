using System;

namespace FizzBuzz_Console{
    class Program{
        private static readonly string nameOfProgram = "FizzBuzz App - type 'exit' to close the app.";

        static void Main(string[] args){
            Console.WriteLine(nameOfProgram);
            int typedNumber;
            Console.WriteLine();
            while(true) {
                Console.Write("\nType number: ");
                string input = Console.ReadLine();
                if(input == "exit")
                    return;
                Console.WriteLine();
                if(!int.TryParse(input, out typedNumber)) {
                    Console.WriteLine("Type number which is integer.");
                    continue;
                }
                if(typedNumber%3 == 0 || typedNumber%5 == 0) {
                    if(typedNumber % 3 == 0) {
                        Console.Write("fizz");
                    }
                    if(typedNumber % 5 == 0) {
                        Console.Write("buzz");
                    }
                    Console.WriteLine();
                } else {
                    Console.WriteLine(typedNumber);
                }

            }
        }
    }
}
