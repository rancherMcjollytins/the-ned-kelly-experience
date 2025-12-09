using UnityEngine;

public class shoot : MonoBehaviour
{
    private Color redcol = Color.red;
    private Ray hitscan;
    private Transform camerapositioning;
    private Vector3 Cameraposit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camerapositioning = GameObject.Find("Main Camera").getComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraposit = camerapositioning.transform.position;
    }

    void OnMouseDown()
    {
        Debug.DrawRay(cameraposit, Cameraposit.forward, redcol);
    }
}
