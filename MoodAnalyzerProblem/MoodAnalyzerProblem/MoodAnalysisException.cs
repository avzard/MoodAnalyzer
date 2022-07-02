using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    /// <summary>
    /// MoodAnalysisException Class For Handelling Exception.
    /// </summary>
    public class MoodAnalysisException : Exception
    {
        /// <summary>
        /// Enum for Exception Type.
        /// </summary>
        public enum ExceptionType
        {
            ENTERED_NULL, ENTERED_EMPTY
        }

        //Creating 'type' variable of type ExceptionType
        ExceptionType type;

        /// <summary>
        /// Parameterized Constructor sets the Exception Type.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public MoodAnalysisException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}