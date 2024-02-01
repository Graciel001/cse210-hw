public class Assignment
{
    private string _studName;
    private string _topic;

    public Assignment(string _studName, string topic)
    {
        _studName = studName;
        _topic = topic;
    }
    
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}