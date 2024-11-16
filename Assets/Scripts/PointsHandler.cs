using UnityEngine;

public class PointsHandler : MonoBehaviour
{
    public int Points { get; private set; }

    public void AddPoints(int value)
    {
        Points += value;
    }

    public void ResetPoints()
    {
        Points = 0;
    }
}
