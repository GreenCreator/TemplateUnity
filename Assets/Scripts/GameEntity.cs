using System;

public class GameEntity<T> where T : EntityData
{
    protected Lazy<T> _data;

    public GameEntity(Func<T> dataLoader)
    {
        _data = new Lazy<T>(dataLoader);
    }

    public T Data => _data.Value;

    public string Name { get; private set; }
    public string Description { get; private set; }
}