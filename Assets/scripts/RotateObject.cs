using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {


	public float speed;
    public bool direction = false;
    private float myFactor = 1;

    // Update is called once per frame


    //public override void Update () {
    void Update() {

        if (direction == true) { myFactor = -1; }
        else { myFactor = 1; }

        // ...also rotate around the World's Y axis
        transform.Rotate(0, speed*Time.deltaTime*myFactor, 0, Space.World);

	}
}