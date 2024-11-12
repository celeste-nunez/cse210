class Resume
{
    private Job jobs;

    public Resume()
    {
        jobs = new Job("Company Name", "Position", 2022, 2024);
    }
    public void Display()
    {
        jobs.Display();
    }
}
