namespace SwitchBoard.States;

public class OffState : State
{
    public override State ChangeState()
    {
        return new OnState();
    }

    public override string GetCurrentState()
    {
        return Enums.State.Off.ToString();
    }
}
