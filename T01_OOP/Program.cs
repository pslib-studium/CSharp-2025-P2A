// See https://aka.ms/new-console-template for more information
using T01_OOP;

Human alois = new Human("Alois", 30);
Student bretislav = new Student("Bretislav", 20, "3.A");
alois.Introduce();
bretislav.Introduce();
Human ctirad = new Student("Ctirad", 25, "4.B");
ctirad.Introduce();
Teacher vaclav = new Teacher("Vaclav", 40, "Mathematics");

List<Human> humans = new List<Human> { alois, bretislav, ctirad, vaclav };
foreach (var item in humans)
{
    item.Introduce();
    if (item is ITeacheable)
    {
        (item as ITeacheable).Teach();
    }
}
List<ITeacheable> teacheables = new List<ITeacheable>();
teacheables.Add(bretislav);
//teacheables.Add(vaclav);
foreach (var item in teacheables)
{
    item.Teach();
}

if (alois.CompareTo(bretislav) > 0) 
    Console.WriteLine("Alois je starsi");
else Console.WriteLine("Bretislav je starsi");
/*
if (alois > bretislav)
    Console.WriteLine("Alois je starsi");
else Console.WriteLine("Bretislav je starsi");
*/

// polymorfismus - schopnost objektů různých tříd reagovat na stejnou zprávu (metodu) různými způsoby
// v tomto případě metoda Introduce() je přepsána v každé třídě (Human, Student, Teacher) a každý objekt reaguje na tuto metodu jinak, i když voláme stejnou metodu na všech objektech.
// tedy každý potomek může být na místě rodičovského typu (Human) a metoda Introduce() bude fungovat správně pro každý typ objektu (Human, Student, Teacher) díky přepsání metody v každé třídě.
