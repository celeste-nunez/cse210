using System.Reflection.Metadata;

class InheritanceProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Mew mew");
        Person chester = new Person("Chester", "Chesterson", 22);

        Console.WriteLine(chester.GetPersonInfo());

        Doctor docChester = new Doctor("Chester", "Chestersen", 75, "Stethoscope");
        Console.WriteLine(docChester.GetDoctorInfo());
        Console.WriteLine(docChester.GetPersonInfo());

        Police popoChester = new Police("Chester", "Chesterson", 23, "Beating stick");
        Console.WriteLine(popoChester.GetPoliceInfo());
        Console.WriteLine(popoChester.GetPersonInfo());
    }
}