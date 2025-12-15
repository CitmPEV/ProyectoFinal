using UnityEngine;

public class WorldListener : MonoBehaviour
{
    private void OnEnable()
    {
        WorldManager.OnWorldStateChanged += OnWorldChanged;
    }

    private void OnDisable()
    {
        WorldManager.OnWorldStateChanged -= OnWorldChanged;
    }

    void OnWorldChanged(float value)
    {
        Debug.Log(name + " received world value: " + value);
    }
}
