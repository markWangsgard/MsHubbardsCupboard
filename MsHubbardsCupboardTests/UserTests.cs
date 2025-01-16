namespace MsHubbardsCupboardTests;
using MsHubbardsLogic;

public class UserTests
{
    [Fact]
    public void UserCreated()
    {
        //given
        string name = "Mark";
        //when
        User user = new User(name);
    }
}
