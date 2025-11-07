using System;

class Program
{
    static void Main(string[] args)
    {
        // Display welcome message
        Console.WriteLine("Welcome to Cow Say!");

        // Main loop: runs continuously until the user types "exit"
        while (true)
        {
            try
            {
                // Ask the user for input
                Console.WriteLine("\nWhat should the cow say? or (type 'exit' to quit)");
                Console.Write("You: ");
                string message = Console.ReadLine() ?? "";

                // Check if input is empty or only whitespace
                if (string.IsNullOrWhiteSpace(message))
                {
                    Console.Error.WriteLine("Cow: hmmm...say something first!");
                    continue; // Go back to the start of the loop
                }
                
                // Exit condition
                if (message.ToLower() == "exit")
                {
                    Console.WriteLine("Cow: Goodbye! Moo!");
                    break; // Exit the loop
                }

                // List of words that the cow does not like
                string[] forbiddenWords = { "error", "fail", "bug" };

                // Check if the message contains any forbidden word
                foreach (var word in forbiddenWords)
                {
                    if (message.ToLower().Contains(word))
                    {
                        // Throw an exception if a forbidden word is found
                        throw new Exception($"Cow doesn't like that word! ('{word}')");
                    }
                }

                // ASCII art representation of the cow
                string cow = @"
                \    ^__^
                 \   (oo)\_______
                    (._.)\       )~~~(>
                        ||----w |
                        ||     ||
                ";

                // Display the message in a "cow say" format
                Console.WriteLine($"\nCow says: {message}");
                Console.WriteLine(cow);

                // If command-line arguments are provided, treat them as fruits
                if (args.Length > 0)
                {
                    string fruit = args.Length == 1 ? "fruit" : "fruits";
                    Console.WriteLine($"You gave {args.Length} {fruit} to the cow.");

                    // Loop through all arguments (fruits)
                    foreach (string arg in args)
                    {
                        Console.WriteLine($"Cow eats the {arg}. Yum!");
                    }

                    Console.WriteLine("Cow: Thank you for the fruits! Moo!\n");
                }
            }

            // Handle forbidden word exceptions
            catch (Exception ex)
            {
                Console.Error.WriteLine($"\nError: {ex.Message}");
            }
        }
    }
}
