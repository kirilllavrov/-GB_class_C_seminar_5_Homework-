Console.WriteLine($"Введите длину массива");
int num = Convert.ToInt32(Console.ReadLine());

int[] nums = new int[num];

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = new Random().Next(1, 100);
}

int max = nums[1];
int min = nums[1];
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] > max)
    {
        max = nums[i];
    }
    if (nums[i] < min)
    {
        min = nums[i];
    }
}

Console.WriteLine(max - min);