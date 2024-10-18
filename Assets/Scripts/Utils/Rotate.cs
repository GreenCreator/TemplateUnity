using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float x = 0.1f;
    [SerializeField] private float y = 0.1f;
    [SerializeField] private float z = 0.1f;

    void Update()
    {
        transform.Rotate(new Vector3(x, y, z));
    }
}