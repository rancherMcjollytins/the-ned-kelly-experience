using UnityEngine;
using UnityEngine.InputSystem;

public class mov : MonoBehaviour
{
    public GameObject playerbody;
    public InputActionAsset playerinputs;
    private InputAction movementAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movementAction = playerinputs.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = movementAction.ReadValue<Vector3>() * Time.deltaTime;

    }
}
