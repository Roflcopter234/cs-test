// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

MatMul matMul = new MatMul();

List<List<double>> l1 = new List<List<double>>();
l1.Add(new List<double>() { 1.0, 2.0 });
l1.Add(new List<double>() { 3.0, 4.0 });

List<List<double>> l2 = new List<List<double>>();
l2.Add(new List<double>() { 5.0, 6.0 });
l2.Add(new List<double>() { 7.0, 8.0 });

List<List<double>> expected = new List<List<double>>();
expected.Add(new List<double>() { 19.0, 22.0 });
expected.Add(new List<double>() { 43.0, 50.0 });

List<List<double>> result = matMul.matMul(l1, l2);

for (int i = 0; i < result.Count; i++)
{
    for (int j = 0; j < result[i].Count; j++)
    {
        Console.WriteLine(result[i][j]);
    }
}
int ii = 0;