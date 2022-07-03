using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace MoodAnalyzer
{
    public class MoodAnalyseFactory
    {
        /// <summary>
        /// Function to Create Instance and Return of MoodAnalyse Class.
        /// </summary>
        /// <returns></returns>
        public static object CreateMoodAnalyse(string className, string constructor)
        {
            try
            {
                Assembly executing = Assembly.GetExecutingAssembly();
                Type moodAnaylseType = executing.GetType(className);
                return Activator.CreateInstance(moodAnaylseType);
            }
            catch (MoodAnalysisException exception)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "No Such Method Found");
            }
            catch (Exception exception)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
            }

        }
    }
}