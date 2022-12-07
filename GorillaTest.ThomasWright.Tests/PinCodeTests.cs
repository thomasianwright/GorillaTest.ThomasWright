namespace GorillaTest.ThomasWright.Tests;

public class PinCodeTests
{
    private readonly string PinSuccessMessage;
    private readonly string PinFailureMessage;

    public PinCodeTests()
    {
        PinSuccessMessage = "Pin is valid";
        PinFailureMessage = "Pin is invalid";
    }
    
    [Theory]
    [InlineData("1234")]
    [InlineData("4312")]
    [InlineData("553452")]
    [InlineData("462536")]
    public void Assert_Test_Success_With_Correctly_Formatted_Pincodes(string value)
    {
        Assert.Equal(PinCode.ParsePinCode(value), PinSuccessMessage);
    }

    [Theory]
    [InlineData("f3d2")]
    [InlineData("42g43")]
    [InlineData("f31342")]
    public void Assert_Test_Failure_With_Incorrectly_Formatted_Pincodes(string value)
    {
        Assert.Equal(PinCode.ParsePinCode(value), PinFailureMessage);
    }
}