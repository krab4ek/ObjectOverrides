namespace ObjectOverrides
{
    internal class Person
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; } = 0;
        public string SSN { get; set; } = string.Empty;

        public Person(string firstName, string lastName, int age, string ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            SSN = ssn;
        }
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            
        }
        public Person()
        {

        }

        public override string ToString() => $"[First name: {FirstName}; Last name: {LastName}; Age: {Age}]";

        public override bool Equals(object? obj) => obj?.ToString() == ToString();


        //public override bool Equals(object? obj)
        //{
        //    if (obj is Person && obj != null)
        //    {
        //        Person temp;
        //        temp = (Person)obj;
        //        if (temp.FirstName == this.FirstName
        //            && temp.LastName == this.LastName
        //            && temp.Age == this.Age)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    return false;

        //}

        public override int GetHashCode()
        {
            return Age.GetHashCode();
        }



    }
}
