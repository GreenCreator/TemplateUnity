using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LocationCardController : MonoBehaviour, IEntityCardController
{
    [SerializeField] private Image LocationImage;
    [SerializeField] private TextMeshProUGUI name;
    [SerializeField] private TextMeshProUGUI description;
    [SerializeField] private Button left;
    [SerializeField] private Button right;
    [SerializeField] private Button load;

    public void SetEntityData(EntityData entityData, IInputHandler handler)
    {
        var locationData = (LocationData)entityData;
        LocationImage.sprite = locationData.EntitySprite;
        name.text = locationData.Name;
        description.text = locationData.Description;
        left.onClick.AddListener(handler.OnPreviousButtonClicked);
        right.onClick.AddListener(handler.OnNextButtonClicked);
        load.onClick.AddListener(handler.OnLoadScene);
    }
}