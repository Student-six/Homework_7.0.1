using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Transform _player;

    [SerializeField] private float _playerStartXPosition;
    [SerializeField] private float _playerStartZPosition;

    [SerializeField] private float _startTimeForTimer;

    [SerializeField] private int _winningNumberPoints;

    [SerializeField] private string _looseMessage;
    [SerializeField] private string _winMessage;

    PointsHandler _pointsHandler;

    private float _timer;

    private bool _isRunning;

    private void Start()
    {
        StartGame();
    }

    private void Update()
    {
        if (_isRunning == false)
            return;

        Debug.Log($"Timer (sec.) -> {_timer}");

        _timer -= Time.deltaTime;

        if (_timer <= 0.0001f)
            GameOver(_looseMessage);

        if (_pointsHandler.Points >= _winningNumberPoints)
            GameOver(_winMessage);
    }

    private void GameOver(string message)
    {
        _player.gameObject.SetActive(false);
        Debug.Log(message);
        _isRunning = false;
    }

    private void StartGame()
    {
        _isRunning = true;

        _timer = _startTimeForTimer;

        _pointsHandler = _player.GetComponent<PointsHandler>();

        _player.gameObject.SetActive(true);
        _player.position = new Vector3(_playerStartXPosition, 0, _playerStartZPosition);
    }
}
