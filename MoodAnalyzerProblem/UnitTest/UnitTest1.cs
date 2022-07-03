using MoodAnalyzer;
using NUnit.Framework;
using System.Reflection;
using System.Reflection.Emit;

namespace MoodAnalyzerTest
{
    /// <summary>
    /// MoodAnalyseTest Class for Test Cases.
    /// </summary>
    public class MoodAnalyseTest
    {
        /// <summary>
        /// Test Case 1.1 if given Sad mood then should return SAD.
        /// </summary>
        [Test]
        public void GivenSadMoodShouldReturnSAD()
        {
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);
            string mood = moodAnalyse.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// Test Case 1.2 given Any Mood Should Return HAPPY.
        /// </summary>
        [Test]
        public void GivenAnyMoodShouldReturnHAPPY()
        {
            string expected = "HAPPY";
            string message = "I am in Any Mood";
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);
            string mood = moodAnalyse.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// Test Case 3.1 If Given Null Throw Excption.
        /// </summary>
        [Test]
        public void GivenNullMoodShouldThrowMoodAnaylsisException()
        {
            string expected = "Please Enter Proper Mood";
            string message = null;
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);
            try
            {
                string mood = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalysisException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        /// Test Case 3.2 If Given Empty mood should throw MoodAnalysisException.
        /// </summary>
        [Test]
        public void GivenEmptyMoodShouldThrowMoodAnalysisException()
        {
            string expected = "Please Enter Proper Mood";
            string message = "";
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);
            try
            {
                string mood = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalysisException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        /// Test Case 4.1 Given MoodAnalyse Class Name Should Return MoodAnalyser Object.
        /// </summary>
        [Test]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            object moodAnalyseObject = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyse", "MoodAnalyse");
            object expected = new MoodAnalyse();
            expected.Equals(moodAnalyseObject);
        }

        /// <summary>
        /// Test Case 4.2 Given Improper Class NAme Should throw MoodAnalyssiException.
        /// </summary>
        [Test]
        public void GivenImproperClassNameShouldThrowMoodAnalysisException()
        {
            string expected = "Class Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyseFactory.CreateMoodAnalyse("DemoClass", "MoodAnalyse");
            }
            catch (MoodAnalysisException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        /// Test Case 4.3 Given Improper Constructor should throw MoodAnalysisException.
        /// </summary>
        [Test]
        public void GivenImproperConstructorShouldThrowMoodAnalysisException()
        {

            string expected = "No Such Method Found";
            try
            {
                object moodAnalyseObject = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyse", "DemoConstructor");
            }
            catch (MoodAnalysisException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
}