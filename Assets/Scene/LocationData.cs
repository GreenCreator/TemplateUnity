using UnityEngine;

public class LocationData : EntityData
{
    public string Description { get; private set; }
    public int SceneID { get; private set; }

    public LocationData(string name, string description, Sprite locationSprite, int sceneID)
    {
        base.Name = name;
        base.EntitySprite = locationSprite;
        Description = description;
        SceneID = sceneID;
    }
}