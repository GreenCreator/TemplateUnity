using UnityEngine;

[CreateAssetMenu(menuName = "Location/Location Data")]
public class LocationDataScrOb : ScriptableObject
{
    [SerializeField] private string nameText;
    [SerializeField] private string description;
    [SerializeField] private Sprite locationSprite;
    [SerializeField] private int sceneID;

    public string GetName()
    {
        return nameText;
    }

    public string GetDescription()
    {
        return description;
    }

    public Sprite GetLocationSprite()
    {
        return locationSprite;
    }

    public int GetSceneID()
    {
        return sceneID;
    }
}