namespace ClassesIntro;

public class Player : Character
{
    public Player(Vector2 position) : base(position)
    {
    }

    public override void ChooseAction()
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(true); //true = ignore (przechwyć input, ale nie wyświetlaj go w konsoli)
        
        ClearPosition();
            
        if (keyInfo.Key == ConsoleKey.A)
        {
            // ruch w lewo
            Move(-1, 0);
        }
        else if (keyInfo.Key == ConsoleKey.D)
        {
            // ruch w prawo
            Move(1, 0);
        }
        else if (keyInfo.Key == ConsoleKey.W)
        {
            // ruch w górę
            Move(0, -1);
        }
        else if (keyInfo.Key == ConsoleKey.S)
        {
            // ruch w dół
            Move(0, 1);
        }
    }
}