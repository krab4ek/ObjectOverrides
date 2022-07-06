using ObjectOverrides;

Console.WriteLine("***** Fun with System.Object *****\n");
Person p1 = new Person();

Console.WriteLine($"ToString: {p1.ToString()}");
Console.WriteLine($"Hash code: {p1.GetHashCode()}");
Console.WriteLine($"Type: {p1.GetType()}");