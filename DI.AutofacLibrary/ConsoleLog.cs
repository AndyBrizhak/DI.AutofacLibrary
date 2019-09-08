using System;

namespace DI.AutofacLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public class ConsoleLog : ILog
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}