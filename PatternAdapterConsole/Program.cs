System.Console.WriteLine("Пример 1. Вызов метода Move через интерфейс Imove у класса Camel через AdapterToCamel");
Camel camel= new Camel();
AdapterToCamel adapterToCamel= new AdapterToCamel(camel);
RunMove(adapterToCamel);

System.Console.WriteLine("Пример 2. Вызов метода Log через интерфейс ILogToCollections у класса ConsoleLoger через AdapterToConsoleLoger");
ConsoleLoger loger= new ConsoleLoger();
AdapterToConsoleLoger adapterToConsoleLoger= new AdapterToConsoleLoger(loger);
RunLog(adapterToConsoleLoger);



static void  RunMove(IMove move){
    move.Move();
}
static void RunLog(ILogToCollections logToCollections)
{
    logToCollections.Log(null,"Данные");
}