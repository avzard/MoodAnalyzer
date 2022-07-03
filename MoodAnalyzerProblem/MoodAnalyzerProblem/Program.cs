using System;

namespace MoodAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the Message");
                string message = Console.ReadLine();
                MoodAnalyse moodAnalyse = new MoodAnalyse(message);
                string mood = moodAnalyse.AnalyseMood();
                Console.WriteLine(mood);
            }
            catch (MoodAnalysisException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}