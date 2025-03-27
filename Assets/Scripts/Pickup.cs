using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PickupPhysics : MonoBehaviour
{
    private Rigidbody rb;
    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();

        // Ensure object starts in place
        rb.isKinematic = true; 

        // Add event listeners for grabbing
        grabInteractable.selectEntered.AddListener(OnGrab);
        grabInteractable.selectExited.AddListener(OnRelease);
    }

    void OnGrab(SelectEnterEventArgs args)
    {
        rb.isKinematic = false; // Enable physics when grabbed
    }

    void OnRelease(SelectExitEventArgs args)
    {
        rb.isKinematic = false; // Keep physics enabled after release
        rb.useGravity = true; // Ensure gravity is applied
    }
}
