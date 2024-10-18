using System;

public class Character : GameEntity<CharacterData>, ISelectable
{
    private Lazy<CharacterData> _characterData;

    public Character(Func<CharacterData> dataLoader) : base(dataLoader)
    {
    }

    public CharacterData Data => _characterData.Value;


    public void Select()
    {
    }
}