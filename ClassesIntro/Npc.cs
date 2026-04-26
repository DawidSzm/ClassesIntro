namespace ClassesIntro;

public class Npc : Character
{
    public Npc(Vector2 startingPosition) : base(startingPosition)
    {
    }

    public override void ChooseAction()
    {
        List<Vector2> availableDirections =
        [
            new Vector2()
        ];
            
        
        ClearAtPosition();
        Move(new Vector2(0, 1));
    }
}

