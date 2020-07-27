using System;
using System.Dynamic;

class SampleClass
{
    public int num1 { get; set; } = 10;
    public int num2 { get; set; } = 0;
    public int warizan { get; set; }
}

class MainClass
{
    static void Main()
    {
        try
        {
            var test = new SampleClass();
            test.warizan = test.num1 / test.num2;
            Console.WriteLine(test.warizan);
        }

        catch
        {
            Console.WriteLine("例外発生");
        }
    }
}