using HomeWorkCalculate.ServiceLayer.Services;


CalculateService calculate = new CalculateService();

var sum = calculate.Calculate(new int[] { 1, 4, 6, 8,12,17,20 });
Console.WriteLine(sum);

var result = calculate.GetCalculate(new int[] { 1, 2, 3, 5,9,13,16,19, 20 });
Console.WriteLine(result);
