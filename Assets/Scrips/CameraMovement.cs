using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraspeed;
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(cameraspeed * Time.deltaTime, 0, 0);
    }
}
