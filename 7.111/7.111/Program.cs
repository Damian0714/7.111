int[] kar = new int[255];
int[] moto = new int[255];
double k = 0;
double o = 0;
int p, i;


Console.WriteLine("Введите количество Машин и Мотоциклов: ");
p = Convert.ToInt32(Console.ReadLine());
for (i = 1; i <= p; i++)
{
    Console.WriteLine("Введите стоимость " + i + "й" + " машины: " +
        "");
    kar[i] = Convert.ToInt32(Console.ReadLine());
}
for (i = 1; i <= p; i++)
{
    Console.WriteLine("Введите стоимость " + i + "" + " мотоцикла: ");
    moto[i] = Convert.ToInt32(Console.ReadLine());
}
for (i = 1; i < p; i++)
{
    o = o + kar[i];
    k = k + moto[i];
}
o = o / p;
k = k / n;
if ((a / 3) > k)
{
    Console.WriteLine("Верно!");
}
else
{
    Console.WriteLine("Не верно!");

}
