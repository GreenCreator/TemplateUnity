using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private HeroDataScrOb[] heroes;
    [SerializeField] private BaseEntitySelectionUIController selectionUIController;

    private BaseSelectionEntity characterSelection;
    private IInputHandler keyboardHandler;
    private IInputHandler uiHandler;

    void Start()
    {
        characterSelection = new CharacterSelection();

        keyboardHandler = new KeyboardInputHandler(characterSelection, selectionUIController);
        uiHandler = new UIInputHandler(characterSelection, selectionUIController);


        foreach (var hero in heroes)
        {
            characterSelection.AddEntity(new GameEntity<EntityData>((() =>
                new CharacterData(hero.GetName(), hero.GetLevel(), hero.GetAvatar(), hero.GetModel()))));
        }

        selectionUIController.Initialize(characterSelection, uiHandler);

        selectionUIController.UpdateEntityUI();
    }

    void Update()
    {
        keyboardHandler.HandleInput();
    }
}