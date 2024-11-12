class Job 
{
    private string company;
    private string jobTitle;
    private int startYear;
    private int endYear;

    public Job(string company, string jobTitle, int startYear, int endYear) 
    {
        this.company = company;
        this.jobTitle = jobTitle;
        this.startYear = startYear;
        this.endYear = endYear;
    }

    public void Display()
    {
        Console.WriteLine($"{company}\nJob Title: {jobTitle}\n{startYear}-{endYear}");
    }
}