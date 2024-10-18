using UnityEngine;

public class CharacterData : EntityData
{
    public int Level { get; private set; }
    public GameObject Model { get; private set; }

    public CharacterData(string name, int level, Sprite avatar, GameObject model)
    {
        base.Name = name;
        base.EntitySprite = avatar;

        Level = level;
        Model = model;
    }
}