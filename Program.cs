

using _03_03_2023_linq_forum;

//human d = new human("эдуард", "коляка", 46)
//Console.WriteLine(d);
human[] peoples = {
    new human("петр", "петров", 36),
    new human("иван", "федоров", 45),
    new human("олег", "киселев", 52),
    new human("андрей", "туралин", 41),
    new human("сергей", "сырцов", 62),
    new human("валерий", "мельников", 56),
    new human("евгений", "тарасов", 43),
    new human("Иван", "шалаев", 35),
    new human("ольга", "еременко", 43),
    new human("света", "пивченко", 56)
    };
var pol = from p in peoples where p.name.StartsWith("е") select p;

//foreach (var ip in pol)
//{
//    Console.WriteLine(ip.ToString());
//}
var data  = peoples.Select(p => p.name).ToList();

foreach (var ppp in data)
{
    Console.WriteLine(ppp.ToString());
}