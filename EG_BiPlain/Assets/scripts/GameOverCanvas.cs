using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverCanvas : MonoBehaviour
{
    void Awake()
    {
        gameObject.SetActive(false);
    }

    public void SetActiveGameOver()
    {
        gameObject.SetActive(true);
    }
}
