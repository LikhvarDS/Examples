using System;
using System.Collections.Generic;
using System.Text;

namespace DisposeProj
{
  class MyClass : IDisposable
  {

    public void Dispose()
    {
      throw new NotImplementedException();
    }
  }
}
