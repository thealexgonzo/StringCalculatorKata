//using StringCalculatorKata;
//using System.Security.AccessControl;

//StringCalculator calculator = new StringCalculator();

//int sum = calculator.Add("1,2");

string nums = "//***\n1***2";

char[] delimeter;

//delimeter = nums.Remove(nums[0], nums.IndexOf('\n')).ToCharArray();

delimeter = nums.ToCharArray(0, nums.IndexOf("1") + 1);

for (int i = 0; i < delimeter.Length; i++)
{
    Console.WriteLine(delimeter[i]);
}
