using UnityEngine;
using UnityEngine.InputSystem;

public class mov : MonoBehaviour
{
    private float speed;
    public GameObject playerbody;
    public InputActionAsset playerinputs;
    private InputAction movementAction;
    private Vector2 Movevector;
    public GameObject camerapos;
    private Vector3 movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movementAction?.Enable();
        speed = 5f;
        movementAction = playerinputs.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        //ai helped to fix and make it work right
        Vector3 cameraRelativityForward = camerapos.transform.forward;
        Vector3 cameraRelativityRight = camerapos.transform.right;

//done with ai help also
        cameraRelativityForward.y = 0;
        cameraRelativityRight.y = 0;
        //why what this do?
        cameraRelativityForward.Normalize();
        cameraRelativityRight.Normalize();

        Movevector = movementAction.ReadValue<Vector2>();

        Vector3 movement = (cameraRelativityForward * Movevector.y + cameraRelativityRight * Movevector.x) * speed * Time.deltaTime;
        playerbody.transform.position += movement;

    }
}
