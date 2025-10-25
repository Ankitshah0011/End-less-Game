using UnityEngine;

public class BGMPersistent : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject); // keeps music playing between scenes
    }
}
