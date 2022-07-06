using ObjectOverrides;

Console.WriteLine("***** Fun with System.Object *****\n");
Person p1 = new Person("Andrei","Covali",32);
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




    Console.ReadLine();
}



