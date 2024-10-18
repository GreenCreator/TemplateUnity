using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCardController : MonoBehaviour, IEntityCardController
{
    [SerializeField] private Image avatarImage;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private Button left;
    [SerializeField] private Button right;

    public void SetEntityData(EntityData entityData, IInputHandler handler)
    {
        var characterData = (CharacterData)entityData;
        
        avatarImage.sprite = characterData.EntitySprite;
        nameText.text = characterData.Name;
        levelText.text = "Уровень: " + characterData.Level;
        left.onClick.AddListener(handler.OnPreviousButtonClicked);
        right.onClick.AddListener(handler.OnNextButtonClicked);
    }
}