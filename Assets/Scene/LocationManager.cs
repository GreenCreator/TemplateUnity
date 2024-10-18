using UnityEngine;

public class LocationManager : MonoBehaviour
{
    [SerializeField] private LocationDataScrOb[] locations;
    [SerializeField] private BaseEntitySelectionUIController locationSelectionUIController;

    private IInputHandler keyboardHandler;

    void Start()
    {
        var locationSelection = new LocationSelection();

        keyboardHandler = new KeyboardInputHandler(locationSelection, locationSelectionUIController);
        var uiHandler = new UIInputHandler(locationSelection, locationSelectionUIController);


        foreach (var location in locations)
        {
            locationSelection.AddEntity(new GameEntity<EntityData>((() =>
                new LocationData(location.GetName(), location.GetDescription(), location.GetLocationSprite(),
                    location.GetSceneID()))));
        }

        locationSelectionUIController.Initialize(locationSelection, uiHandler);

        locationSelectionUIController.UpdateEntityUI();
    }

    void Update()
    {
        keyboardHandler.HandleInput();
    }
}