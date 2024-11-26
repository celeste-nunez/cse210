class Police : Person
{
    private string _weapon;
    public Police(string firstName, string lastName, int age, string weapon) :base(firstName, lastName, age)
    {
        _weapon = weapon;
    }
    
    public string GetPoliceInfo()
    {
        return $"{_weapon}, {GetPersonInfo()}";
    }
}