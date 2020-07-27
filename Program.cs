using System;
using System.Dynamic;

class SampleClass
{
    public int num1 { get; set; } = 10;
    public int num2 { get; set; } = 2;
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

            throw new CustomException("例外をスロー");
        }

        catch(Exception e)
        {
            Console.WriteLine(e.Source);
            Console.WriteLine(e.Message);
        }
    }
}

//独自の例外クラスを定義
class CustomException : Exception
{
    public CustomException( string msg ) : base(msg)
    {
    }
}