using System.Diagnostics;
using ClassesIntro;
// See https://aka.ms/new-console-template for more information
// string playerAvatar = "@";
// Console.WriteLine(playerAvatar);

Vector2 startingPosition = new Vector2(4, 2);
Player hero = new Player(startingPosition);

var heroClones = new List<Player>();
heroClones.Add(hero);
heroClones.Add(new Player(startingPosition));


foreach (var clone in heroClones)
{
    clone.Display();
}

while (true)
{
    for (int i = 0; i < heroClones.Count; i++)
    {
        Player currentHeroClone = heroClones[i];
        
        currentHeroClone.Display();
        
        ConsoleKeyInfo keyInfo = Console.ReadKey(true); //true = ignore (przechwyć input, ale nie wyświetlaj go w konsoli)
        
        currentHeroClone.ClearPosition();
            
            if (keyInfo.Key == ConsoleKey.A)
            {
                // ruch w lewo
                currentHeroClone.Move(-1, 0);
            }
            else if (keyInfo.Key == ConsoleKey.D)
            {
                // ruch w prawo
                currentHeroClone.Move(1, 0);
            }
            else if (keyInfo.Key == ConsoleKey.W)
            {
                // ruch w górę
                currentHeroClone.Move(0, -1);
            }
            else if (keyInfo.Key == ConsoleKey.S)
            {
                // ruch w dół
                currentHeroClone.Move(0, 1);
            }
            
            currentHeroClone.Display();
    }

}