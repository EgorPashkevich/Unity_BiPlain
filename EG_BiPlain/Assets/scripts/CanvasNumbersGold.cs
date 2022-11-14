using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CanvasNumbersGold : MonoBehaviour
{
    public int Numbers;
    public Text NumbersText;

    void Update()
    {
        NumbersText.text = ": " + Numbers.ToString();
    }
}
