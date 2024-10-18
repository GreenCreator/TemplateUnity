public class CharacterSelectionUIController : BaseEntitySelectionUIController
{
    public Character3DManager character3DManager;

    public override void UpdateEntityUI()
    {
        base.UpdateEntityUI();
        var currentEntity = entitySelection.GetCurrentEntity();
        if (currentEntity.Data is CharacterData characterData)
        {
            baseCardUI.CreateEntityCard(characterData, handler);
            character3DManager.CreateCharacter(characterData.Model);
        }
    }
}