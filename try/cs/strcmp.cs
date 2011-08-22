// Techtopia doesn't understand .NET strings. http://www.techotopia.com/index.php/Working_with_Strings_in_C_Sharp

using System;

public static class MainClass {
  public static int Main(string[] args) {
    String myString1 = "Hello World";
    String myString2 = "Hello World";

    if (myString1 == myString2)
    {
      System.Console.WriteLine ("They match");
    }
    else
    {
      System.Console.WriteLine ("They do not match");
    }
    return 0;
  }
}
