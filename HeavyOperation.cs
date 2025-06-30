namespace HeavyOperation
{
  internal class Heavy
  {
    int sum = 0;

    public void heavyOperation()
    {
      for (int i = 0; i < 100000000; i++)
      {
        sum += i;
      }
      Console.WriteLine($"heavy operation has been completed {sum}");
    }
  }
}