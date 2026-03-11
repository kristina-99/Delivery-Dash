using UnityEngine;

public class Delivery : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Package"))
        {
            Debug.Log("Picked up package");
        }
        else if (collision.CompareTag("Customer"))
        {
            Debug.Log("Package delivered");
        }
    }
}
