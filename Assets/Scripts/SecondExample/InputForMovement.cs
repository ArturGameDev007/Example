using UnityEngine;

public class InputForMovement : MonoBehaviour
{
    private readonly string _horizontal = "Horizontal";
    private readonly string _vertical = "Vertical";

    [SerializeField] private CharacterMove _character;

    private float _horizontalInput;
    private float _verticalinput;

    private void Update()
    {
        _horizontalInput = Input.GetAxis(_horizontal);
        _verticalinput = Input.GetAxis(_vertical);

        _character.Move(new Vector3(_horizontalInput, 0, _verticalinput).normalized);
    }
}
