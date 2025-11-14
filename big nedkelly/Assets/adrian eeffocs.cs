using UnityEngine;

public class adrianeeffocs : MonoBehaviour
{
    [SerializeField] private Vector3 lookingVector;
    [SerializeField] private float RotationY;
    public GameObject playerobject;

    public float camSensitivity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camSensitivity = 90f;
    }

    // Update is called once per frame
    void Update()
    {
        RotationY = Input.GetAxis("Mouse Y") * camSensitivity;
        lookingVector = new Vector3(0, RotationY, 0);

        playerobject.transform.rotation = Quaternion.Euler(lookingVector.x, lookingVector.y, lookingVector.z);
    }
}
