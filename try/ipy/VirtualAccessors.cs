public class Base {
  public virtual int Accessor {
    get; set;
  }
}

public class GetOverride: Base {
  public override int Accessor {
    get {
      return base.Accessor - 1;
    }
  }
}

public class SetOverride: Base {
  public override int Accessor {
    set {
      base.Accessor = value + 1;
    }
  }
}

