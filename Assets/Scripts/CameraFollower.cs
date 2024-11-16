using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform _target;

    [SerializeField] private Vector3 _offsetPosition;
    [SerializeField] private Vector3 _cameraRotation;

    private Camera _camera;

    private void Awake()
    {
        _camera = GetComponent<Camera>();
    }

    private void LateUpdate()
    {
        _camera.transform.SetPositionAndRotation(_target.position + _offsetPosition, Quaternion.Euler(_cameraRotation));
    }
}
