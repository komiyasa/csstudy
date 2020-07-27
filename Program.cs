using System;

//基本クラス
class Music
{
    public virtual void BaseInfo()
    {
        Console.WriteLine("Music");
    }
}

//継承クラス
class Song : Music
{
    public override void BaseInfo()
    {
        Console.WriteLine("Song");
    }
}

class Music2 : Music
{
    public override void BaseInfo()
    {
        Console.WriteLine("Mudic");
    }
}

class MainClass
{
    static void Main()
    {
        Song s = new Song();
        s.BaseInfo();

        Music2 m2 = new Music2();
        m2.BaseInfo();

        Music m = new Music();
        m.BaseInfo();
    }
}