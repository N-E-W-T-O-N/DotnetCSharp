
/*int v = Convert.ToInt32(Console.ReadLine());
//var v = Console.ReadLine();
//var s = new List<char>();
//if(v != null)
  for (var i=v.Length-1; i>=0; i--)
{
        s.Add(v[i]);
}

foreach(char c in s)
{ Console.Write(c); }
*/

var s = "1,2,3,4,5";

var x = s.Split(',');
foreach(var i in x)
Console.Write($"{i} ");