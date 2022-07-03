using MoodAnalyzer;
using System;

/// <summary>
/// MoodAanalyse Class To Check The Mood And Respond.
/// </summary>
public class MoodAnalyse
{
    //Variable
    private string message;

    /// <summary>
    /// Default Constructor
    /// </summary>
    public MoodAnalyse() { }

    /// <summary>
    /// Parameterised Constructor.
    /// </summary>
    /// <param name="message"></param>
    public MoodAnalyse(string message)
    {
        this.message = message;
    }


    /// <summary>
    /// AnalyseMood Function To Check The Mood And Respond HAPPY or SAD.
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public string AnalyseMood()
    {
        try
        {
            if (message.Length == 0)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.ENTERED_EMPTY, "Please Enter Proper Mood");
            }
            if (this.message.Contains("Sad", StringComparison.OrdinalIgnoreCase))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
        catch (NullReferenceException exception)
        {
            throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.ENTERED_NULL, "Can Not Set Null To Field");
        }
    }

    public Boolean equals(object anyObject)
    {
        if (this.message.Equals(((MoodAnalyse)anyObject).message))
            return true;
        return false;
    }
}