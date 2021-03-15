using Unity;

namespace Common
{
  public static class Dependency
  {
    private static readonly UnityContainer container = new UnityContainer();

    public static void RegisterType<IFrom, ITo>() where ITo : IFrom
    {
      container.RegisterType<IFrom, ITo>();
    }

    public static T Reslove<T>()
    {
      return container.Resolve<T>();
    }
  }
}
