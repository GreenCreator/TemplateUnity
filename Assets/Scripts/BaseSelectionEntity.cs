using System.Collections.Generic;

public abstract class BaseSelectionEntity : ISelectionEntity<EntityData>
{
    private List<GameEntity<EntityData>> entities = new List<GameEntity<EntityData>>();
    private int currentIndex = 0;

    public void AddEntity(GameEntity<EntityData> entity)
    {
        entities.Add(entity);
    }

    public virtual GameEntity<EntityData> GetCurrentEntity()
    {
        return entities[currentIndex];
    }

    public virtual void SelectNextEntity()
    {
        currentIndex = (currentIndex + 1) % entities.Count;
    }

    public virtual void SelectPreviousEntity()
    {
        currentIndex = (currentIndex - 1 + entities.Count) % entities.Count;
    }
}