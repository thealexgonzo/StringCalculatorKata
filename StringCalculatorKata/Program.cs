//using StringCalculatorKata;
//using System.Security.AccessControl;

//StringCalculator calculator = new StringCalculator();

//int sum = calculator.Add("1,2");

string nums = "//***\n1***2";

char[] delimeter = [];

char[] delimeter2;

for (int i = 0; i < nums.IndexOf('\n'); i++)
{
    delimeter.Append(nums[i]);
}

for (int i = 0; i < delimeter.Length; i++)
{
    Console.WriteLine(delimeter[i]);
}