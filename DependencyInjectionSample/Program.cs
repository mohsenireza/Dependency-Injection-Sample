using System;

namespace DependencyInjectionSample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var logger = new Logger();
            var student = new Student(logger);
            student.Register();
            Console.ReadKey();
        }
    }

    public class Student
    {
        private ILogger Logger;

        public Student(ILogger logger)
        {
            this.Logger = logger;
        }

        public void Register()
        {
            Logger.Log("Student was registered...");
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public class Logger: ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
