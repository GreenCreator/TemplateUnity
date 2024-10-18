using UnityEngine;

public abstract class BaseEntitySelectionUIController : MonoBehaviour, IEntitySelectionUIController
{
    [SerializeField] protected BaseCardUI baseCardUI;
    protected ISelectionEntity<EntityData> entitySelection;

    protected IInputHandler handler;

    public virtual void Initialize(ISelectionEntity<EntityData> selection, IInputHandler handler)
    {
        entitySelection = selection;
        this.handler = handler;
    }

    public virtual void UpdateEntityUI()
    {
    }
}