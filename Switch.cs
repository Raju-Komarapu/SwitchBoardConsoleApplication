using SwitchBoard.Appliances;
using SwitchBoard.States;

namespace SwitchBoard;

public class Switch(Appliance appliance)
{
    private readonly Appliance Appliance = appliance;

    public void ChangeState()
    {
        this.Appliance.ChangeState();
    }

    public string GetState()
    {
        return this.Appliance.GetApplianceState();
    }

    public State GetApplianceState()
    {
        return this.Appliance.State;
    }

    public string GetApplianceName()
    {
        return string.Join(" ",this.Appliance.Name, this.Appliance.SequenceNumber);
    }
}
