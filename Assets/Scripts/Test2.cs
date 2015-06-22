using UnityEngine;
using System.Collections;

public class Test2 : MonoBehaviour {
    public Vector3 prev;
	// Use this for initialization
	void Start () {
        prev = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        var diff = transform.position - prev;
        if (diff.magnitude > 0.01)
        {
            transform.rotation = Quaternion.LookRotation(diff);
        }
        prev = transform.position;
	}
}
