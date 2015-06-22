﻿using UnityEngine;
using System.Collections;

public class Test1 : MonoBehaviour {
    Test test;
	// Use this for initialization
	void Start () {
        // マウスの座標をスクリーン座標系に変換  (1)
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 mousePos = ray.origin;

        // マウスから矢印へのベクトルを正規化  (2)
        Vector3 diff = mousePos - transform.position;
        Vector3 norm = diff.normalized;



        // マウスの方向を向かせる (4)
        if (Input.GetButtonDown("Fire1"))
        {
            float deg = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(0, 0, deg - 180);
        }
	}
	
	// Update is called once per frame
	void Update () {
        // マウスの座標をスクリーン座標系に変換  (1)
      /*  Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 mousePos = ray.origin;

        // マウスから矢印へのベクトルを正規化  (2)
        Vector3 diff = mousePos - transform.position;
        Vector3 norm = diff.normalized;



        // マウスの方向を向かせる (4)
        if (Input.GetButtonDown("Fire1"))
        {
            float deg = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(0, 0, deg - 180);
        }
     */
	}
}
