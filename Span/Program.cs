// See https://aka.ms/new-console-template for more information
int[] array = new int[100];
Sum(array);
int[] three = [1, 2, 3];
Sum(three);

List<int> values = [21, 3, 0, 2, 1, 3, 1, 23, 1, 231, 2, 31, 23];
Sum(new Span<int>(values.ToArray()));

ReadOnlySpan<byte> str = "Hello Who Are You?"u8;
unsafe
{
    int* ptr = stackalloc int[1000];
    Sum(new Span<int>(ptr,1000));
}
static void Sum(Span<int> values)
{
    int sum = 0;
    foreach (var x in values)
    {
        sum += x;
    }
    Console.WriteLine(sum);
}