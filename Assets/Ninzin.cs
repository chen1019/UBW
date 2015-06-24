using UnityEngine;
using System.Collections;

public class Ninzin : MonoBehaviour{

	// Spaceshipコンポーネント
	Exp exp;

	// ぶつかった瞬間に呼び出される
	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "Bullet"){ // ぶつかったオブジェクトの判別


			Destroy(gameObject);
		}
	}
}