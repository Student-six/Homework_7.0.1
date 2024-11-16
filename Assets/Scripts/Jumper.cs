using UnityEngine;

public class Jumper : MonoBehaviour
{
    [SerializeField] private float _jumpForce;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.VelocityChange);
    }
}
