using UnityEngine;
using UnityEngine.Events;

public class ItemTrigger : MonoBehaviour
{
    public UnityEvent onEnter;
    public UnityEvent onExit;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            onEnter.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            onExit.Invoke();
        }
    }
}