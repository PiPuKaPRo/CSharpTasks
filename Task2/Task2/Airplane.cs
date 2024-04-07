namespace Task2;
public class Airplane : Aircraft
{
    public double RunwayLength { get; set; }
    
    public override bool TakeOff()
    {
        if (RunwayLength >= 1000)
        {
            DisplayMessage("Самолет взлетел.");
            return true;
        }
        else
        {
            DisplayMessage("Взлеточная полоса слишком короткая.");
            return false;
        }
    }
    
    public override bool Land()
    {
        DisplayMessage("Самолет приземлился.");
        return true;
    }
}

