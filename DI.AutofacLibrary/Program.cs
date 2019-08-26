namespace DI.AutofacLibrary
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      var log = new ConsoleLog();
      var engine = new Engine(log);
      var car = new Car(engine, log);
      car.Go();
    }
  }
}