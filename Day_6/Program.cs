int num1 = 0,
num2 = 1,
num3,
i,
myNum = 10;

Console.WriteLine("The fibonacci series are : ");

for(i = 0; i < myNum; ++i)
{
    num3=num1 + num2;
    Console.WriteLine(num3);
    num1 = num2;
    num2 = num3;
}
