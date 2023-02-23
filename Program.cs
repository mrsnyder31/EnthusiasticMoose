﻿using System;
using System.Collections.Generic;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("H I, A S K  A  Q U E S T I O N !");

    // MooseAsks(
    //     "Is Canada real?",
    //     "Really? It seems very unlikely.",
    //     "I K N E W I T !!"
    //     );

    // MooseAsks(
    //     "Are you enthusiastic?",
    //     "Yay!",
    //     "You should try it!"
    //     );

    // MooseAsks(
    //     "Do you love C# yet?",
    //     "Good job sucking up to your instructor!",
    //     "You will...oh, yes, you will..."
    //     );

    // MooseAsks(
    //     "Do you want to know a secret?",
    //     "ME TOO!!!! I love secrets...tell me one!",
    //     "Oh, no...secrets are the best, I love to share them!"
    //     );

}



void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}



// void MooseAsks(string question, string yes, string no)
// {
//     Console.Write($"{question} (Y/N): ");
//     string answer = Console.ReadLine().ToLower();

//     while (answer != "y" && answer != "n")
//     {
//         Console.Write($"{question} (Y/N): ");
//         answer = Console.ReadLine().ToLower();
//     }

//     if (answer == "y")
//     {
//         MooseSays(yes);
//     }
//     else
//     {
//         MooseSays(no);
//     }
// }


var response = new List<string>()
    {
        "As I see it, yes.",
        "Ask again later.",
        "Better not tell you now.",
        "Cannot predict now.",
        "Concentrate and ask again.",
        "Don’t count on it.",
        "It is certain.",
        "It is decidedly so.",
        "Most likely.",
        "My reply is no.",
        "My sources say no.",
        "Outlook not so good.",
        "Outlook good.",
        "Reply hazy, try again.",
        "Signs point to yes.",
        "Very doubtful.",
        "Without a doubt.",
        "Yes.",
        "Yes – definitely.",
        "You may rely on it."
    };



MagicMoose();

void MagicMoose()
{
    Console.Write("***");
    var answer = Console.ReadLine().ToLower();

    Random r = new Random();
    int resRand = r.Next(0, 19);

    if (answer == "")
    {
        MooseSays("Goodbye...");
        Environment.Exit(0);
    }
    else
    {
        MooseSays(response[resRand]);
    }

}

