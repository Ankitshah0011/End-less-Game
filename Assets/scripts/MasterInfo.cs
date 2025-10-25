using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // for TextMeshPro

public class MasterInfo : MonoBehaviour
{
    public static int coinCount = 0; // static so all scripts can access it

    [SerializeField] GameObject coinDisplay;

    void Update()
    {
        // Get the TMP_Text component from the GameObject
        coinDisplay.GetComponent<TMP_Text>().text = "COINS: " + coinCount;
    }
}
