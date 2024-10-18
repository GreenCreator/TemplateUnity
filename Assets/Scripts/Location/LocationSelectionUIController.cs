public class LocationSelectionUIController : BaseEntitySelectionUIController
{
    public override void UpdateEntityUI()
    {
        base.UpdateEntityUI();

        var currentEntity = entitySelection.GetCurrentEntity();
        if (currentEntity.Data is LocationData location)
        {
            baseCardUI.CreateEntityCard(location, handler);
        }
    }
}