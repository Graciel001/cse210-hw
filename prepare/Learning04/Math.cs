public class Math : Assignment
{
    private string _txtbookSection;
    private string _problems;

    public Math(string studentName, string topic, string _txtbookSection, string problems)
        : base(studentName, topic)
    {
        _txtbookSection = txtbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_txtbookSection} Problems {_problems}";
    }
}