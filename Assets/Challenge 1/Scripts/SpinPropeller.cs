using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    public Vector3 rotationX= new Vector3(0,0,20);
    public float Rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationX*Time.deltaTime * Rotation);
    }
}
