using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Cow Say!");

        while (true)
        {
            Console.WriteLine("What should the cow say? or (type 'exit' to quit)");
            Console.Write("You: ");
            string message = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(message))
            {
                Console.WriteLine("Cow: hmmm...say something first!");
                continue;
            }
            
            if (message.ToLower() == "exit")
            {
                Console.WriteLine("Cow: Goodbye! Moo!");
                break;
            }

            Console.WriteLine($"Cow says: {message}");
            string cow = @"
            \    ^__^
             \   (oo)\_______
                (._.)\       )~~~(>
                     ||----w |
                     ||     ||
            ";


            Console.WriteLine(cow);
            if (args.Length > 0)
            {
                Console.WriteLine($"You gave {args.Length} fruit/s to the cow.");
                foreach (string fruit in args)
                {
                    Console.WriteLine($"Cow eats the {fruit}. Yum!");
                }
                Console.WriteLine("Cow: Thank you for the fruits! Moo!\n");
            }
            
        }
    }
}
