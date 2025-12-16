using TMPro;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TextMeshProUGUI _distanceDisplay;
    [SerializeField] private float _minDistanceForDetected;

    private float _distanceToPlayer;

    private Vector3 _enemyPosition;
    private Vector3 _directionToPlayer;

    private void Start()
    {
        _enemyPosition = transform.position;
    }

    private void Update()
    {
        Direction();
    }

    private void Direction()
    {
        _directionToPlayer = _player.transform.position - _enemyPosition;
        _distanceToPlayer = _directionToPlayer.sqrMagnitude;

        _distanceDisplay.text = _distanceToPlayer.ToString("0.0") + "m";

        if (_distanceToPlayer < _minDistanceForDetected)
        {
            _distanceDisplay.color = Color.red;
            Debug.DrawLine(_enemyPosition, _player.transform.position, Color.red);
        }
        else
        {
            _distanceDisplay.color = Color.yellow;
            Debug.DrawLine(_enemyPosition, _player.transform.position, Color.yellow);
        }
    }
}
