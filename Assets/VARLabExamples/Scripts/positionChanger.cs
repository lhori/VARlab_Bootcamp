using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class positionChanger : MonoBehaviour
{
    Vector3 objPosition;
    // Start is called before the first frame update
    void Start()
    {
        objPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {       
        this.transform.position = new Vector3(objPosition.x, Mathf.Sin(Time.time) * 3.0f + objPosition.y, objPosition.z);
    }
}
