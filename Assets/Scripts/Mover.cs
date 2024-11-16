using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _moveX;
    private float _moveZ;

    private Rigidbody _rigidbody;

    private string _moveXAxis = "Horizontal";
    private string _moveZAxis = "Vertical";

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _moveX = Input.GetAxisRaw(_moveXAxis);
        _moveZ = Input.GetAxisRaw(_moveZAxis);
    }

    private void FixedUpdate()
    {
        Vector3 direction = new Vector3(_moveX * _speed, 0, _moveZ * _speed);

        _rigidbody.AddForce(direction, ForceMode.Acceleration);
    }
}
