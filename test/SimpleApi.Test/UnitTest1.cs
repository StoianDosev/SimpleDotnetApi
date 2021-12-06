using SimpleApi.Controllers;
using Xunit;

namespace SimpleApi.Test;

public class UnitTest1
{
    WeatherForecastController controller = new WeatherForecastController();
    [Fact]
    public void Test1()
    {
        var a = controller.Get();
        Assert.NotEmpty(a);
    }
}