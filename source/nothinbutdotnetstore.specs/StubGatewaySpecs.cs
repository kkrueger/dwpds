 using Machine.Specifications;
 using developwithpassion.specifications.rhinomocks;
 using developwithpassion.specifications.extensions;
using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.specs
{   
  public class StubGatewaySpecs
  {
    public abstract class concern : Observes<IStubGateway,
                                      stub_gateway>
    {
        
    }

    [Subject(typeof(stub_gateway))]
    public class when_requesting_a_stub : concern
    {
      private Because b = () =>
        result = sut.Get<StubMissingRequest>();
      

      private It should_return_a_stub = () => result.ShouldBeAn<StubMissingRequest>();

      private static StubMissingRequest result;
    }
  }
}
