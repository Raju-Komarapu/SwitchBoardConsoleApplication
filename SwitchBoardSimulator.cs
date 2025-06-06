using SwitchBoard.Appliances;
using SwitchBoard.States;

namespace SwitchBoard;
public static class SwitchBoardSimulator
{

    public static List<Switch> Switches = [];

    public static void Initialize()
    {
        Console.WriteLine($"""
                            Welcome to the SwitchBoard simulation 

                            Please select to configure switchboard

                            """);

        int userSelection;

        ApplianceManager.Initialize();
        var listOfAppliances = ApplianceManager.Appliances;

        foreach (var item in listOfAppliances)
        {
            Switches.Add(new Switch(item));
        }

        while (true)
        {
            try
            {
                DisplayAppliances();

                Console.Write("\nPlease select an appliance to toggle its state: ");
                userSelection = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                var selectedSwitch = Switches[userSelection - 1];
                Console.WriteLine($"1. Switch {selectedSwitch.GetApplianceName()} \"{(selectedSwitch.GetApplianceState() is OnState ? "Off" : "On")}\"\n");
                Console.WriteLine($"2. Back");

                Console.Write("\nPlease select an option: ");
                userSelection = Convert.ToInt32(Console.ReadLine());
                switch (userSelection)
                {
                    case 1:
                        selectedSwitch.ChangeState();
                        break;
                    case 2:
                        continue;

                }

                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Please select a valid option\n");
            }
        }

    }

    private static void DisplayAppliances()
    {
        Console.WriteLine("--------------------------------------------------------------\n");
        for (int i = 0; i < Switches.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Switches[i].GetState()}\n");
        }
        Console.WriteLine("--------------------------------------------------------------");
    }
}
