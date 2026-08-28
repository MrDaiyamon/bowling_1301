using UnityEngine;

public class Hole : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Pins p = other.GetComponent<Pins>();

        if (p != null)
        {
            GameManager.instance.ShowNotiText(p.Point);
            Destroy(p.gameObject);
        }
    }
}
