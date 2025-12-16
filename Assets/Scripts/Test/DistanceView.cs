using TMPro;
using UnityEngine;

namespace Assets.Scripts.Test
{
    public class DistanceView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private Player _player;

        private void Awake()
        {
            _text = GetComponent<TextMeshProUGUI>();
        }

        private void OnEnable()
        {
            _player.ChangeDistance += OnShowInfoDistance;
        }

        private void OnDisable()
        {
            _player.ChangeDistance -= OnShowInfoDistance;
        }

        private void OnShowInfoDistance(float value)
        {
            _text.text = value.ToString("F1") + " m";

            DrawLineDistance();
        }

        private void DrawLineDistance()
        {
            Color colorLine = (_player.DistanceToEnemy < _player.MinDistanceForDetected) ? Color.red : Color.yellow;
            _text.color = colorLine;

            if (colorLine == Color.red)
                Debug.Log("Враг вас заметил.");

            Debug.DrawLine(_player.transform.position, _player.Enemy.transform.position, colorLine);
        }
    }
}
