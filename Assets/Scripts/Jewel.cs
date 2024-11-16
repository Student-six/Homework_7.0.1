using UnityEngine;

public class Jewel : MonoBehaviour
{
    [SerializeField] private int _addPoint;

    private void OnTriggerEnter(Collider other)
    {
        PointsHandler pointsHandler = other.GetComponent<PointsHandler>();

        if (pointsHandler != null)
        {
            pointsHandler.AddPoints(_addPoint);

            gameObject.SetActive(false);
        }
    }
}
