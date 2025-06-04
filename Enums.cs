using System.ComponentModel;

namespace SwitchBoard;
public class Enums
{
    public enum State
    { 
        [Description("On")]
        On,
        [Description("Off")]
        Off
    }
}
