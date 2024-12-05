using System.Reflection.Metadata;

class InheritanceProgram
{
    public static void SetPersonFirstName(Person person, string firstName)
    {
        person.SetFirstName(firstName);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Mew mew");
        // Person chester = new Person("Chester", "Chesterson", 22);

        // Console.WriteLine(chester.GetPersonInfo());

        Doctor docChester = new Doctor("Chester", "Chestersen", 75, "Stethoscope");
        Console.WriteLine(docChester.GetDoctorInfo());
        Console.WriteLine(docChester.GetPersonInfo());

        Police popoChester = new Police("Chester", "Chesterson", 23, "Beating stick");
        Console.WriteLine(popoChester.GetPoliceInfo());
        Console.WriteLine(popoChester.GetPersonInfo());

        SetPersonFirstName(popoChester, "Doug the second");
        Console.WriteLine(popoChester.GetPoliceInfo());
        Console.WriteLine(popoChester.GetPersonInfo());

        SetPersonFirstName(docChester, "Chester the Earl of Sussox");
        Console.WriteLine(docChester.GetDoctorInfo());
        Console.WriteLine(docChester.GetPersonInfo());

        List<Person> people = new List<Person>();
        // people.Add(bob);
        // people.Add(betty);
        people.Add(docChester);
        people.Add(popoChester);

        foreach(Person person in people)
        {
            Console.WriteLine(person.GetPersonInfo());
        }


    }

}