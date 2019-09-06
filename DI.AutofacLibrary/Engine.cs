using System;

namespace DI.AutofacLibrary
{
    /// <summary>
    /// +++
    /// </summary>
    public class Engine
    {
        private ILog log;
        private int id;
/// <summary>
/// 
/// </summary>
/// <param name="log"></param>
        public Engine(ILog log)
        {
            this.log = log;
            id = new Random().Next();
        }

        public void Ahead(int power)
        {
            log.Write($"Engine [{id}] ahead {power}");
        }
    }
}