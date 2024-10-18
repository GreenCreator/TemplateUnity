using UnityEngine;

public class Character3DManager : MonoBehaviour
{
    [SerializeField] private Transform characterSpawnPoint;
    private GameObject currentCharacter;

    public void CreateCharacter(GameObject characterPrefab)
    {
        if (currentCharacter != null)
        {
            Destroy(currentCharacter);
        }

        currentCharacter = Instantiate(characterPrefab, characterSpawnPoint);
    }
}