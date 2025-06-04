using SwitchBoard.States;

namespace SwitchBoard.Appliances;
public static class ApplianceManager
{
    public static List<Appliance> Appliances = [];

    public static void Initialize()
    {
        int numberOfFans = CaptureUserInput("1. Number Of Fans");
        int numberOfAcs = CaptureUserInput("2. Number Of ACs");
        int numberOfBulbs = CaptureUserInput("3. Number Of Bulbs");

        CreateAppliances<Fan>(numberOfFans);
        CreateAppliances<AC>(numberOfAcs);
        CreateAppliances<Bulb>(numberOfBulbs);
    }

    private static void CreateAppliances<T>(int numberOfAppliances) where T : Appliance, new()
    {
        int sequence = 1;
        var applianceList = Enumerable.Range(0, numberOfAppliances)
                                      .Select(_ =>
                                      {
                                          return new T
                                          {
                                              SequenceNumber = sequence++,
                                              State = new OffState()
                                          };
                                      });

        Appliances.AddRange(applianceList);
    }

    public static int CaptureUserInput(string promt)
    {
        while (true)
        {
            try
            {
                Console.WriteLine(promt + "\n");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please provide a valid number.");
                continue;
            }
        }
    }
}
