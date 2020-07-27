using System;

//基本クラス
class Music
{
    int type = 0;
    protected string name = "Music";

    public void SetType(int type)
    {
        this.type = type;
    }

    public virtual void BaseInfo()
    {
        Console.WriteLine(type);
        Console.WriteLine(name);
    }
}

//継承クラス
class Song : Music
{
    public override void BaseInfo()
    {
        this.name = "Song";
        base.BaseInfo();
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