using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    public Transform Player;
    public float SpeedCamera;
    private Vector3 _position;
    void Start()
    {
        _position = Player.InverseTransformPoint(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        var _newposition = Player.TransformPoint(_position);
        transform.position = Vector3.Lerp(transform.position, _newposition, SpeedCamera * Time.deltaTime);
    }
}
