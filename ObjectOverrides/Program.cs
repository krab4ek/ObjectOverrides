using ObjectOverrides;

Console.WriteLine("***** Fun with System.Object *****\n");
Person p1 = new Person("Andrei", "Covali", 32);
Person p3 = new Person();
Console.WriteLine($"ToString: {p1.ToString()}");
Console.WriteLine($"Hash code: {p1.GetHashCode()}");
Console.WriteLine($"Type: {p1.GetType()}");

Person p2 = p1;
object o2 = p2;

if (o2.Equals(p1) && p2.Equals(p1) /*&& p3.Equals(p1)*/)
{
    Console.WriteLine("Ekvivalentni");
}
else
{
    Console.WriteLine("Ne Ekvivalenti");

}

var per1 = new Person("Homer", "Simpson", 50, "777-888-999");
var per2 = new Person("Homer", "Simpson", 50, "777-888-999");

Console.WriteLine($"per1.ToString() = {per1.ToString}");
Console.WriteLine($"per2.ToString() = {per2.ToString}");

Console.WriteLine($"per1 = per2: {per1.Equals(per2)}");

Console.WriteLine($"Same hash code: {per1.GetHashCode() == per2.GetHashCode()}");
Console.WriteLine();

per2.Age = 45;
Console.WriteLine($"per1.ToString() = {per1.ToString}");
Console.WriteLine($"per2.ToString() = {per2.ToString}");
Console.WriteLine($"per1 = per2: {per1.Equals(per2)}");

Console.WriteLine($"Same hash code: {per1.GetHashCode() == per2.GetHashCode()}");
Console.WriteLine();




StaticMemberOfObject();

Console.ReadLine();



static void StaticMemberOfObject()
{
    Person per3 = new Person("Sally", "O`Sullivan", 56);
    Person per4 = new Person("Sally", "O`Sullivan", 56);
    Console.WriteLine($"Per3 and Per4 have same state: {object.Equals(per3, per4)}");
    Console.WriteLine($"Per3 and Per4 are pointing to same object: {object.ReferenceEquals(per3, per4)}");
}
