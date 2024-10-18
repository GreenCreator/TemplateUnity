public interface ISelectionEntity<T> where T : EntityData
{
    void AddEntity(GameEntity<EntityData> entity);

    GameEntity<EntityData> GetCurrentEntity();

    void SelectNextEntity();

    void SelectPreviousEntity();
}