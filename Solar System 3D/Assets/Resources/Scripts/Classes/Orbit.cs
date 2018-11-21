using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : OrbitAbstraction {

    public float rotSpeed;

    void Start() {
        timer = 0;
        centerPoint = GameObject.Find ("Sun").transform;
        offset = transform.position.z;
    }

	void Update () {
        timer += Time.deltaTime * rotSpeed;
        orbit ();
	}

    public override void orbit ()
    {
        float x = Mathf.Cos (timer) * offset;
        float y = transform.position.y;
        float z = Mathf.Sin (timer) * offset;
        Vector3 pos = new Vector3 (x, y, z);
        transform.position = pos + centerPoint.position;
    }
        
}