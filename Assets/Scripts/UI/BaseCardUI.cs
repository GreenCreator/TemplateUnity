using UnityEngine;

public class BaseCardUI : MonoBehaviour
{
    [SerializeField] private GameObject cardPrefab;
    [SerializeField] private Transform parentTransform;

    private GameObject currentCard;

    public void CreateEntityCard(EntityData entityData, IInputHandler handler)
    {
        if (currentCard != null)
        {
            Destroy(currentCard);
        }

        currentCard = Instantiate(cardPrefab, parentTransform);
        var cardController = currentCard.GetComponent<IEntityCardController>();

        cardController.SetEntityData(entityData, handler);
    }
}