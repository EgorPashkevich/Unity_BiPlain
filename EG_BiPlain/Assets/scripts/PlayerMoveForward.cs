using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveForward : MonoBehaviour
{
    private Rigidbody _rigidbody;  
    public float speed;
    public float SpeedPlayerRotate;
    private float _playerRotate;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // private void Update() {
    //     if(Random.Range(0, 2) == 1) {
    //         _playerRotate += SpeedPlayerRotate * Time.deltaTime;
    //         _playerRotate = Mathf.Clamp(_playerRotate, -30f, 30f);
    //         transform.localEulerAngles = new Vector3(0, 0, _playerRotate);
    //     }else {
    //         _playerRotate -= SpeedPlayerRotate * Time.deltaTime;
    //         _playerRotate = Mathf.Clamp(_playerRotate, -30f, 30f);
    //         transform.localEulerAngles = new Vector3(0, 0, _playerRotate);
    //     }
        
    // }
    void FixedUpdate() {
        Vector3 forwardLocal = _rigidbody.transform.forward;
        
        _rigidbody.AddForce(forwardLocal * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        if(Input.GetKey(KeyCode.W)){
            _rigidbody.AddForce(forwardLocal * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }
        if(Input.GetKey(KeyCode.S)){
            Vector3 backLocal = transform.TransformVector(Vector3.back);
            _rigidbody.AddForce(backLocal * speed/1.5f * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }
    }
}
