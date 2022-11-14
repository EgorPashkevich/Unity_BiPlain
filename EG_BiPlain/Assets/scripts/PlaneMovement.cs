using UnityEngine;

namespace Scenes
{
    public class PlaneMovement : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private float _moveSpeed = 25f;
        [SerializeField] private float _rotateSpeed = 10f;
        
        private Quaternion _rotation;
        private Vector3 _moveVelocity;

        private void Start() {
            _rigidbody = GetComponent<Rigidbody>();
        }
        
        private void Update()
        {
            _rotation = _rigidbody.rotation;
            TrackRotationX();
            TrackForwardMove();
        }

        private void FixedUpdate()
        {
            ForwardMove();
            Rotate();
        }
        
        private void TrackRotationX()
        {
            if (Input.GetKey(KeyCode.A))
            {
                _rotation = _rigidbody.rotation * Quaternion.Euler(Vector3.left * _rotateSpeed * Time.fixedDeltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                _rotation = _rigidbody.rotation * Quaternion.Euler(Vector3.right * _rotateSpeed * Time.fixedDeltaTime);
            }
        }

        private void TrackForwardMove()
        {
            var moveDirection = transform.forward;
            
            _moveVelocity = moveDirection * _moveSpeed * Time.fixedDeltaTime;
            
            if (Input.GetKey(KeyCode.W))
            {
                _moveVelocity *= 2;
            }
            if (Input.GetKey(KeyCode.S))
            {
                _moveVelocity = -_moveVelocity;
            }
        }
        
        private void Rotate()
        {
            _rigidbody.MoveRotation(_rotation);
        }
        
        private void ForwardMove()
        {
            _rigidbody.AddForce(_moveVelocity, ForceMode.VelocityChange);
        }
    }
}
