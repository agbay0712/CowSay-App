using System;

class Program
{
    static void Main(string[] args)
    {
        // 1️⃣ Ask for input if not given
        Console.Write("Wha   xt should the cow say? ");
        string message = Console.ReadLine();

        // 2️⃣ Draw the speech bubble
        string bubble = $"  {new string('=', message.Length)}\n";
        bubble += $"| {message} |\n";
        bubble += $"  {new string('=', message.Length)}\n";

        // 3️⃣ Draw the cow
        string cow = @"
        \   ^__^
         \  (oo)\_______
            (__)\       )\/\
                ||----w |
                ||     ||
        ";

        // 4️⃣ Print the result
        Console.WriteLine(bubble + cow);

        // Console.WriteLine("Welcome to Cow Say!");

        // while (true)
        // {
        //     Console.WriteLine("What should the cow say? or (type 'exit' to quit)");
        //     Console.Write("You: ");
        //     string message = Console.ReadLine() ?? "";

        //     if (string.IsNullOrWhiteSpace(message))
        //     {
        //         Console.WriteLine("Cow: hmmm...say something first!");
        //         continue;
        //     }
            
        //     if (message.ToLower() == "exit")
        //     {
        //         Console.WriteLine("Cow: Goodbye! Moo!");
        //         break;
        //     }

        //     Console.WriteLine("$ Cow says: {message}");
        //     string cow = @"
        //     \    ^__^
        //      \   (oo)\_______
        //         (._.)\       )~~~(>
        //              ||----w |
        //              ||     ||
        //     ";


        //     Console.WriteLine(cow);
        // }
    }
}