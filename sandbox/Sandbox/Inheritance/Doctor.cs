class Doctor : Person
{
    private string _tools;
    public Doctor(string firstName, string lastName, int age, string tools) :base(firstName, lastName, age)
    {
        _tools = tools;
    }
    
    public string GetDoctorInfo()
    {
        return $"{_tools}, {GetPersonInfo()}";
    }
}