namespace DI.AutofacLibrary
{
    /// <summary>
    /// +++
    /// </summary>
    public class Car
    {
        private Engine engine;
        private ILog log;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="log"></param>
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
}