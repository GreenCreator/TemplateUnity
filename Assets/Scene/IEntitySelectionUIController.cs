public interface IEntitySelectionUIController
{
    void Initialize(ISelectionEntity<EntityData> selection, IInputHandler handler);
    void UpdateEntityUI();
}