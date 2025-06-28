
string nums = "1,";

string[] numbers = nums.Split('\n', ',');

int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
    
    //sum += int.Parse(numbers[i]);
}

Console.WriteLine(numbers.Length);

//Console.WriteLine(sum);
