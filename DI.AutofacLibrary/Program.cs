namespace DI.AutofacLibrary
{
  public class Car
  {
    private Engine engine;
    private ILog log;

    public Car(Engine engine, ILog log)
    {
      this.engine = engine;
      this.log = log;
    }

    public void Go()
    {
      engine.Ahead(100);
      log.Write("Car going forward...");
    }
  }

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