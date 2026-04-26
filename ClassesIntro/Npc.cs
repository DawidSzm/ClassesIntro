namespace ClassesIntro;

public class Npc : Character
{
    public Npc(Vector2 startingPosition) : base(startingPosition)
    {
    }

    public override void ChooseAction()
    {
        ClearAtPosition();
        Move(1, 0);
    }
}