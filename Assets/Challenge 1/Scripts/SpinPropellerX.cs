using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new UnityEngine.Vector3(0,0,200) * Time.deltaTime);
    }
}
