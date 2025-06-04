namespace SwitchBoard.States;

public class OnState : State
{
    public override State ChangeState()
    {
        return new OffState();
    }

    public override string GetCurrentState()
    {
        return Enums.State.On.ToString();
    }
}
