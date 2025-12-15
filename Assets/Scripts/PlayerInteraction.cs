using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    public float interactionRange = 3f;

    void Update()
    {
        if (Keyboard.current == null) return;

        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            Debug.Log("E PRESSED");

            Ray ray = Camera.main.ScreenPointToRay(
                new Vector2(Screen.width / 2f, Screen.height / 2f)
            );

            if (Physics.Raycast(ray, out RaycastHit hit, interactionRange))
            {
                Debug.Log("HIT: " + hit.collider.name);

                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if (interactable != null)
                {
                    interactable.Interact();
                }
            }
            else
            {
                Debug.Log("NO HIT");
            }
        }
    }
}
