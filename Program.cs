Random rnd = new();

Console.SetWindowSize(40, 12);

//Console.WriteLine($"szélesség: {Console.WindowWidth} karakter");
//Console.WriteLine($"magasság: {Console.WindowHeight} karakter");

//string nev = "Juhász Zoltán";

//Console.SetCursorPosition(
//    left: Console.WindowWidth / 2 - nev.Length / 2,
//    top: Console.WindowHeight / 2);

//Console.WriteLine(nev);

string[] sorok =
{
    "I am a world before I am a man",
    "I was a creature before I could stand",
    "I will remember before I forget",
    "Before I forget that",
};

for (int i = 0; i < sorok.Length; i++)
{
    Console.SetCursorPosition(
        left: Console.WindowWidth / 2 - sorok[i].Length / 2,
        top: (Console.WindowHeight / 2) - (sorok.Length / 2) + i);

    for (int j = 0; j < sorok[i].Length; j++)
    {
        Thread.Sleep(100);
        Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);

        Console.Write(sorok[i][j]);
    }
    Console.Write('\n');
}

//Console.SetCursorPosition(5, 5);
//Console.WriteLine(lyrics);

//for(int i = 0; i < lyrics.Length; i++)
//{
//    if (lyrics[i] == 'e' || lyrics[i] == 'E')
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//    }
//    Console.Write(lyrics[i]);
//    Console.ResetColor();
//}

Console.ReadKey();