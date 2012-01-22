using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;

namespace Unity
{
  interface IFoo
  {
    string Name { get; set; }
  }
  class Foo: IFoo
  {
    private string name_;
    public string Name {
      get {
        return name_;
      }
      set {
        name_ = value;
      }
    }
    public Foo(string name)
    {
      name_ = name;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      var container = new UnityContainer();
      container.RegisterType<IFoo,Foo>(new ContainerControlledLifetimeManager(), new InjectionConstructor("Scott"));
      IFoo myFoo = container.Resolve<IFoo>();
      IFoo myFoo2 = container.Resolve<IFoo>();
      Console.WriteLine(myFoo.Name);
      Console.WriteLine(Object.ReferenceEquals(myFoo, myFoo2));
    }
  }
}
