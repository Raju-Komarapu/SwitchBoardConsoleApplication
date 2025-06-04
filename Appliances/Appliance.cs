using SwitchBoard.States;

namespace SwitchBoard.Appliances;

public class Appliance
{
    public Guid Identifier;

    public string Name => GetType().Name;

    public int SequenceNumber;

    public State State;

    public Appliance()
    {
        this.Identifier = Guid.NewGuid();
    }

    public string GetApplianceState()
    {
        return $"{this.Name} {this.SequenceNumber} is \"{State.GetCurrentState()}\"";
    }


    public void ChangeState()
    {
        this.State = this.State.ChangeState();
    }
}
