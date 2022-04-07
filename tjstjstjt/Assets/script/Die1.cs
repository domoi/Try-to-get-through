using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Die1 : MonoBehaviour
{
    public static int diecount;
    public static Text die1;

    void Start()
    {
        die1 = GetComponent<Text>();
    }

    void Update()
    {
        die1.text = "Умерли: " + diecount;
    }
}
