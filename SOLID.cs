class Singer
{
    public string Name { get; set; }
    public Singer(string name)
    {
        this.Name = name;
    }

    public void SingNellyCiobanu()
    {
        Console.WriteLine("Tu Iubire");
        Console.WriteLine("Tu si Eu");
        Console.WriteLine("Vine Anul Nou");
    }
}

Singer singer = new Singer("Vasile");
singer.SingNellyCiobanu();
singer.SingIonSuruceanu(); -nu este posibil.




class Singer
{
    public string Name { get; set; }

    public Singer(string name)
    {
        this.Name = name;
    }

    public void Sing(ISing sing)
    {
        sing.Sing();
    }
}

interface ISing
{
    void Sing();
}
class SingNellyCiobanu : ISing
{
    public void Sing()
    {
        Console.WriteLine("Tu Iubire");
        Console.WriteLine("Tu si Eu");
        Console.WriteLine("Vine Anul Nou");
    }
}
class SingIonSuruceanu : ISing
{
    public void Sing()
    {
        Console.WriteLine("Ce seara minunata");
        Console.WriteLine("Melancolie");
    }
}

Singer singer = new Singer("Vasile");
singer.Sing(new SingNellyCiobanu());
Console.WriteLine();
singer.Sing(new SingIonSuruceanu());


AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA

class Account
{
    public int Capital { get; protected set; }

    public virtual void SetCapital(int money)
    {
        if (money < 0)
            throw new Exception("Not allowed less than zero lei");
        this.Capital = money;
    }
}

class MicroAccount : Account
{
    public override void SetCapital(int money)
    {
        if (money < 0)
            throw new Exception("Not allowed less than zero lei ");

        // if (money > 100) throw new Exception("Нельзя положить на счет больше 100");

        this.Capital = money;
    }

    public override void SetCapital(int money, bool aditionalVerification)
    {
        if (money < 0)
            throw new Exception("Not allowed less than zero lei ");

        if (money > 100) throw new Exception("Нельзя положить на счет больше 100");

        this.Capital = money;
    }

}



AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA

interface ISing
{
    void PrepareVoice();
    void PrepareSound();
    void SingRock();
    void SingFolk();
}


class IonSuruceanu : ISingFolk
{
    public string Name { get; set; }
    public Singer(string name)
    {
        this.Name = name;
    }
    ...
    // public void SingRock()
    // {
    //     throw new NotImplementedException();
    // }
}

interface ISing
{
    void PrepareVoice();
    void PrepareSound();
}

interface ISingRock : ISing
{
    void SingRock();
}

interface ISingFolk : ISing
{
    void SingFolk();
}



