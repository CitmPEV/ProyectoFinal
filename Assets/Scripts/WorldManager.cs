using System;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    public static WorldManager Instance;

    public float worldValue = 0f;

    public static event Action<float> OnWorldStateChanged;

    private void Awake()
    {
        Instance = this;
        Debug.Log("WorldManager Awake");
    }

    public void AddWorldValue(float amount)
    {
        worldValue = Mathf.Clamp(worldValue + amount, -1f, 1f);
        Debug.Log("World Value: " + worldValue);
        OnWorldStateChanged?.Invoke(worldValue);
    }
}
