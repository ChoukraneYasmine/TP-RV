using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; // Référence au véhicule
    private Vector3 offset;
    void Start()
    {
        offset = new Vector3(0, 5, -7);
    }
    void Update()
    {
        transform.position = player.transform.position + offset;
    }

}
