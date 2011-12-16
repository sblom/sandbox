import java.lang.*;

class TryFinallyParadox {
  public static void main (String[] args) {
    System.out.println(paradox());
  }
  public static Boolean paradox() {
    try {
      return true;
    }
    finally {
      return false;
    }
  }
}
