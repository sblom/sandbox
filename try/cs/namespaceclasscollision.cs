using Foo;

namespace Foo {
  public class Foo {
    public Foo() {}
  }
  public class Foo2 {
    public Foo2() {}
  }
}

namespace Bar {
  public class Baz {
    public Baz() {
      Foo foo = new Foo();
      Foo2 foo2 = new Foo2();
    }
  }
}
