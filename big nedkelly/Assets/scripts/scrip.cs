using UnityEngine;

public class scrip : MonoBehaviour
{
    //used google and ai and help stuffs to make
    private Vector3 lookaround;
    public GameObject playerbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        lookaround = new Vector3(0, Input.GetAxis("Mouse X"), 0) * 200 * Time.deltaTime;
        playerbody.transform.Rotate(lookaround);
    }
}
