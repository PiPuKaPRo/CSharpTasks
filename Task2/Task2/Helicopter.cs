namespace Task2;

public class Helicopter : Aircraft
{
    public override bool TakeOff()
    {
        DisplayMessage("Вертолет взлетел.");
        return true;
    }
    
    public override bool Land()
    {
        DisplayMessage("Вертолет приземлился.");
        return true;
    }
}


