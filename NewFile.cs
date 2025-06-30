namespace MyFirstApp
{
  public class NewClass
  {
    // default is private
    private int val = 0;
    public void setVal(int item)
    {
      val = item;
    }
    public void getVal()
    {
      Console.WriteLine(val);
    }
  }
}