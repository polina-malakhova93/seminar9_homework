int number = Input("Введите число: ");
int count = 2;
NaturalNumber(number, count);
Console.WriteLine(1);

void NaturalNumber(int n, int count)
{
  if (count > n) 
  return;
  NaturalNumber(n, count + 1);
  Console.Write(count + ", ");
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
