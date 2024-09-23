namespace PatternAdapterTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestExample3()
    {
        Camel camel= new Camel();
        AdapterToCamel adapterToCamel= new AdapterToCamel(camel);
        Assert.DoesNotThrow(delegate
        {
            adapterToCamel.Move();
        });

    }
    [Test]
    public void TestExample2()
    {
        ConsoleLoger loger= new ConsoleLoger();
        AdapterToConsoleLoger adapterToConsoleLoger= new AdapterToConsoleLoger(loger);
        Assert.DoesNotThrow(delegate
        {
            adapterToConsoleLoger.Log(null,"Данные");
        });
    }

}