using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 rotateBy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.gameObject.transform.Rotate(Vector3.right, rotateBy.x * Time.deltaTime);
        this.gameObject.transform.Rotate(Vector3.up, rotateBy.y * Time.deltaTime);
        this.gameObject.transform.Rotate(Vector3.forward, rotateBy.z * Time.deltaTime);
    }
}
