using UnityEngine;

public class Hole : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Pins p = other.GetComponent<Pins>();
        Bowling b = other.GetComponent<Bowling>();

        if (p != null)
        {
            GameManager.instance.ShowNotiText(p.Point);
            Destroy(p.gameObject);
        }
        if (b != null)
        {
            Destroy(b.gameObject);
        }
    }
}
