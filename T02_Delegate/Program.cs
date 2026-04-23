// See https://aka.ms/new-console-template for more information

Console.WriteLine(Calculate(2, 3, Add));
Console.WriteLine(Calculate(4, 5, (x, y) => { return x * y; }));
// arrow operator
// lambda expression, anonymous function, inline function
// closure - uzavření proměnných z okolního kontextu
Console.WriteLine(Calculate2(4, 5, (x, y) => (x * y)));
List<int> numbers = new() { 1, 12, 3, 40, 5, 7, 10, 20 };
//numbers.Sort();
Console.WriteLine("Numbers:");
foreach (var n in numbers.Select(x => new Container { Value = x}))
{
    Console.WriteLine(n);
}


float Add(float x, float y)
{
    return x + y;
}
float Subtract(float x, float y)
{
    return x - y;
}

float Calculate(float a, float b, Operation op)
{
    return op(a, b);
}
float Calculate2(float a, float b, Func<float, float, float> op)
{
    return op(a, b);
}

// Func - delegát pro metody s návratovou hodnotou
// Action - delegát pro metody bez návratové hodnoty
// Predicate - delegát pro metody vracející bool

delegate float Operation(float x, float y); // typ pro podprogramy

class Container
{
    public float Value { get; set; }
    public override string ToString()
    {
        return " * " + Value.ToString();
    }
}

// LINQ - Language Integrated Query
// Extension metody
// OrderBy - řazení
// OrderByDescending - řazení sestupně
// Where - filtrování
// Take - výběr prvních n prvků
// Skip - přeskočení prvních n prvků
// Select - projekce, transformace prvků
// GroupBy - seskupování prvků podle klíče
// Aggregate - agregace prvků do jedné hodnoty
// LINQ + EFC - Entity Framework Core = dotazování na databázi pomocí LINQ

// Extension metody - umožňují přidat nové metody do existujících typů bez nutnosti dědičnosti nebo modifikace původního typu
// float Foo(var trida, float param) {...}
// trida.Foo(param) - instance method