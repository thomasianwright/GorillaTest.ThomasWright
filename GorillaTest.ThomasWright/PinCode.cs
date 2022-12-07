namespace GorillaTest.ThomasWright;

public static class PinCode
{
    public static string ParsePinCode(string pin)
    {
        if (pin.Length is 4 or 6 && int.TryParse(pin, out var _))
        {
            return "Pin is valid";
        }

        return "Pin is invalid";
    } 
}