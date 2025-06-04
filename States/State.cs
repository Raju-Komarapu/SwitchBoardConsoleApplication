namespace SwitchBoard.States;

public abstract class State
{
    public abstract State ChangeState();

    public abstract string GetCurrentState();
}
