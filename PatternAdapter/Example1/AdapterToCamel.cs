public class AdapterToCamel : IMove //адаптер
{
    Camel camel; //вызов объекта класса с описанием верблюда
    public AdapterToCamel(Camel camel)
    {
        this.camel = camel; 
    }
    public void Move()
    {
        camel.Move(); //интерфейс IMove реализовал логику интерфейса IMoveAnimal
    }
}
