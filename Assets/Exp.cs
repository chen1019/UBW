using UnityEngine;
using System.Collections;

public class Exp : MonoBehaviour
{

	// 爆発のPrefab
	public GameObject explosion;
	
	// 爆発の作成
	public void Explosion ()
	{
		Instantiate (explosion, transform.position, transform.rotation);
	}

}