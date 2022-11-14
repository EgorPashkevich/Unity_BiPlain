using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoveTail : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float ForceTail;
    
    void Start() {
        _rigidbody = GetComponent<Rigidbody>();
    }

  
    private void FixedUpdate() {
        if(Input.GetKey(KeyCode.A)){
            Vector3 downLocal = transform.TransformVector(Vector3.down);
            _rigidbody.AddForce(downLocal * ForceTail, ForceMode.Impulse);
        }
        if(Input.GetKey(KeyCode.D)){
            Vector3 upLocal = transform.TransformVector(Vector3.up);
            _rigidbody.AddForce(upLocal * ForceTail, ForceMode.Impulse);
        }
    }
}
