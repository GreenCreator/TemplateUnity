using UnityEngine;

public class KeyboardInputHandler : BaseInputHandler
{
    public KeyboardInputHandler(BaseSelectionEntity selection, IEntitySelectionUIController selectionUIController) :
        base(selection, selectionUIController)
    {
    }

    public override void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            OnNextButtonClicked();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            OnPreviousButtonClicked();
        }
    }
}