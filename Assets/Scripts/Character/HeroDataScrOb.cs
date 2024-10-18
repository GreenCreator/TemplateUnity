using UnityEngine;

[CreateAssetMenu(menuName = "Hero/Hero Data")]
public class HeroDataScrOb : ScriptableObject
{
    [SerializeField] private GameObject model;
    [SerializeField] private Sprite avatarSprite;
    [SerializeField] private string nameText;
    [SerializeField] private int levelText;

    public GameObject GetModel()
    {
        return model;
    }

    public Sprite GetAvatar()
    {
        return avatarSprite;
    }

    public string GetName()
    {
        return nameText;
    }

    public int GetLevel()
    {
        return levelText;
    }
}