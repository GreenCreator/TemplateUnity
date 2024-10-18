using System;
using UnityEngine.SceneManagement;

public abstract class BaseInputHandler : IInputHandler
{
    private BaseSelectionEntity characterSelection;
    private Action OnCharacterChange;

    protected BaseInputHandler(BaseSelectionEntity selection, IEntitySelectionUIController selectionUIController)
    {
        characterSelection = selection;
        OnCharacterChange += selectionUIController.UpdateEntityUI;
    }

    public virtual void HandleInput()
    {
    }

    public virtual void OnNextButtonClicked()
    {
        characterSelection.SelectNextEntity();
        OnCharacterChange?.Invoke();
    }

    public virtual void OnPreviousButtonClicked()
    {
        characterSelection.SelectPreviousEntity();
        OnCharacterChange?.Invoke();
    }

    public void OnLoadScene()
    {
        var currentEntity = characterSelection.GetCurrentEntity();
        if (currentEntity.Data is LocationData location)
        {
            var sceneID = location.SceneID;
            SceneManager.LoadScene("SampleSceneName" + sceneID);
        }
    }
}