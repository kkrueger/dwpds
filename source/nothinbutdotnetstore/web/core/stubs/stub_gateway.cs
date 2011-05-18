using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nothinbutdotnetstore.web.core.stubs
{
  public class stub_gateway : IStubGateway
  {
    public StubType Get<StubType>() where StubType : new()
    {
      return new StubType();
    }
  }
}
