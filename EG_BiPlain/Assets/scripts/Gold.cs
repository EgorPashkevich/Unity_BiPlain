using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    public float SpeedRotate;
    void Start()
    {
        transform.Rotate(0, 0, 90f);
    }

    void Update()
    {
        transform.Rotate(SpeedRotate * Time.deltaTime, 0f, 0f);
    }

    private void OnTriggerEnter(Collider other) {
        FindObjectOfType<CanvasNumbersGold>().Numbers += 1;
        Destroy(gameObject);
    }
}
