using System.Threading.Tasks;
namespace MyFirstApp
{
  class Program
  {
    public static async Task Main(string[] args)
    {
      Console.WriteLine("hello world");
      NewClass newClass = new MyFirstApp.NewClass();
      newClass.setVal(10);
      newClass.getVal();


      HeavyOperation.Heavy heavyObj = new HeavyOperation.Heavy();
      var task = Task.Run(() =>
      {
        // Task.Delay(5500);
        Thread.Sleep(4000);
        heavyObj.heavyOperation();
      });
      Console.WriteLine("after the heavy operation");
      await task;
    }
  }
}
