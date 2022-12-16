Console.WriteLine($"Введите длину массива");
int num = Convert.ToInt32(Console.ReadLine());

int[] nums = new int[num];

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = new Random().Next(100, 1000);
}

int result = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] % 2 == 0)
    {
        result++;
    }

    Console.WriteLine($"{nums[i]}, ");
}
Console.WriteLine(result);