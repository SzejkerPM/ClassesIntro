namespace ClassesIntro;

public class Npc : Character
{
    public Npc(Vector2 position) : base(position)
    {
    }

    public override void ChooseAction()
    {
        while (true)
        {
            ClearPosition();

            int randomDirection = Random.Shared.Next(0, 3);
            
            switch (randomDirection)
            {
                case 0:
                    Move(-1, 0);
                    break;
                case 1:
                    Move(1, 0);
                    break;
                case 2:
                    Move(0, -1);
                    break;
                case 3:
                    Move(0, 1);
                    break;
            }

            Thread.Sleep(2000);
        }
    }
}