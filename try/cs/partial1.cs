using System;

public class Base {
}

public interface IFoo {
  void SomeMethod();
}

public partial class PartialTest: IFoo {
}

public class MainClass {
  public static int Main(string[] args) {
    Base pt1 = new PartialTest();
    IFoo pt2 = new PartialTest();
    Console.WriteLine("pt1 is a {0}", pt1.GetType());
    Console.WriteLine("pt2 is a {0}", pt2.GetType());
    return 0;
  }
}
