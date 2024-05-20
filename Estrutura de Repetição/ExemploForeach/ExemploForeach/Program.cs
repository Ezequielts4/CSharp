/* Array */

/*
int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine(num[i]);
}


foreach (var n in num)
{
    Console.WriteLine(n);
}
*/

 /* List */

List<int> num = new List<int>();

for (int i = 0; i <= 10; i++)
{
    num.Add(i);
}

foreach (var n in num)
{
    Console.WriteLine(n);
}