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

    public override string GetPersonInfo()
    {
        return $"I am a police man, my fav weapon is: {_weapon}, My info is: {base.GetPersonInfo()}";
    }
}