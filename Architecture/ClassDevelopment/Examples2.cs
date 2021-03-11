using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDevelopment
{
  public class Examples2
  {
    private int InnerMethod(int param1, ref double param2, out string param3)
    {
      int localvariable = param1;
      param1 += localvariable;
      param2 = param2 - param1;
      param3 = "str";  // обязательно
      return param1;
    }

    public string CallingMethod()
    {
      int param1Value = 5;
      double param2Value = 6;
      string param3Value;
      int result = InnerMethod(param1Value, ref param2Value, out param3Value);

      return string.Format("result: {0}\nparam1Value: {1}\nparam2Value: {2}\nparam3Value: {3}", result, param1Value, param2Value, param3Value);
    }
  }
}
