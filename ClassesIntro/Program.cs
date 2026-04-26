using System.Diagnostics;
using ClassesIntro;

Vector2 startingPosition = new Vector2(4, 2);
Player hero = new Player(startingPosition);

var characters = new List<Character>();
characters.Add(hero);
characters.Add(new Npc(startingPosition));


foreach (var clone in characters)
{
    clone.Display();
}

while (true)
{
    for (int i = 0; i < characters.Count; i++)
    {
        var currentCharacter = characters[i];
        
        currentCharacter.Display();
        
        currentCharacter.ChooseAction();
            
        currentCharacter.Display();
    }

}