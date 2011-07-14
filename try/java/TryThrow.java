class TryThrow {
  public static void main(String[] args) throws Exception {
    try {
      throw new Exception("asdf");
    } catch (Exception e) {
      //throw e;
    }
  }
}
