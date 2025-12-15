using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float worldModifier = 0.2f;
    private bool used = false;

    public void Interact()
    {
        if (used) return;
        used = true;

        Debug.Log("Interactable Interact");

        transform.localScale *= 0.5f;
        GetComponent<Renderer>().material.color = Color.cyan;

        WorldManager.Instance.AddWorldValue(worldModifier);
    }
}
