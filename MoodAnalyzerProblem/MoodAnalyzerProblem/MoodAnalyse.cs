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
    /// </summary>s
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
        if (this.message.Contains("Sad"))
        {
            return "SAD";
        }
        else
        {
            return "HAPPY";
        }
    }
}