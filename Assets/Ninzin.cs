using UnityEngine;
using System.Collections;

public class Ninzin : MonoBehaviour{

	// 爆発のPrefab
	public GameObject explosion;
	
	// 爆発の作成
	public void Explosion ()
	{
		Instantiate (explosion, transform.position, transform.rotation);
	}

	void OnTriggerEnter2D (Collider2D c)
	{
		// 弾の削除
		Destroy(c.gameObject);

		// プレイヤーを削除
		Destroy (gameObject);
	}
}