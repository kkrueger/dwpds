namespace nothinbutdotnetstore.web.core.stubs
{
  public interface IStubGateway
  {
    StubType Get<StubType>() where StubType : new();
  }
}