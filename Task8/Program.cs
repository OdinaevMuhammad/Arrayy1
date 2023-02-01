var rnd = new Random();
var array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var shuffledArray = array.OrderBy(i => rnd.Next());
foreach (var item in shuffledArray)
{
    Console.Write(item + " ");
}