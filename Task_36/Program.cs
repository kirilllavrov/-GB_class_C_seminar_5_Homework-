Console.WriteLine($"Введите длину массива");
int num = Convert.ToInt32(Console.ReadLine());

int[] nums = new int[num];

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = new Random().Next(1, 100);
}

// Вариант 1
int result = 0;
for (int i = 0; i < nums.Length; i = i + 2)
{
    result = result + nums[i];
}
Console.WriteLine(result);

// Вариант 2

int result1 = 0;
int j = 0;
while (j < num)
{
    result1 = result1 + nums[j];
    j = j + 2;
}
Console.WriteLine(result1);