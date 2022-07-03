using System;
using System.Reflection;

namespace MoodAnalyzer
{
    public class MoodAnalyseFactory
    {
        /// <summary>
        /// Function to get Parameteres Constructor.
        /// </summary>
        /// <returns></returns>
        public static ConstructorInfo GetConstructor(string className)
        {
            try
            {
                Type type = typeof(MoodAnalyse);
                Type[] types = new Type[1];
                types[0] = typeof(string);
                ConstructorInfo constructorInfo = type.GetConstructor(types);
                return constructorInfo;
            }
            catch (MoodAnalysisException exception)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "No Such Class Found");
            }
        }

        /// <summary>
        /// Function to Create Instance From Parameteries Constructor.
        /// </summary>
        /// <param name="constructorInfo"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static object CreateMoodAnalyse(ConstructorInfo constructorInfo, string[] message)
        {
            if (constructorInfo.Equals(MoodAnalyseFactory.GetConstructor("MoodAnalyse")))
            {
                object newObject = constructorInfo.Invoke(message);
                return newObject;
            }
            else
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "No Such Method Found");
            }
        }

        /// <summary>
        /// Function to Invoke AnlyseMood Function Using Reflection.
        /// </summary>
        /// <param name="methodName"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string InvokeAnalyseMood(string methodName, string message)
        {
            try
            {
                string[] messageAr = { message };
                Type type = Type.GetType("MoodAnalyse");
                ConstructorInfo constructorInfo = MoodAnalyseFactory.GetConstructor("MoodAnalyse");
                object moodAnalyseObject = MoodAnalyseFactory.CreateMoodAnalyse(constructorInfo, messageAr);
                MethodInfo analyseMoodInfo = type.GetMethod(methodName);
                object mood = analyseMoodInfo.Invoke(moodAnalyseObject, null);
                return mood.ToString();
            }
            catch (System.NullReferenceException exception)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "No Such Method Found");
            }
        }
    }
}