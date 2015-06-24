using UnityEngine;
using System.Collections;

public class Ninzin : MonoBehaviour{

	// Spaceshipコンポーネント
	Exp exp;
    Spaceship spaceship;
    IEnumerator Start()
    {

        // Spaceshipコンポーネントを取得
        exp = GetComponent<Exp>();



        // canShotがfalseの場合、ここでコルーチンを終了させる
        if (spaceship.canShot == false)
        {
            yield break;
        }

        while (true)
        {

            // 子要素を全て取得する
            for (int i = 0; i < transform.childCount; i++)
            {

                Transform shotPosition = transform.GetChild(i);

                // ShotPositionの位置/角度で弾を撃つ
                spaceship.Shot(shotPosition);
            }

            // shotDelay秒待つ
            yield return new WaitForSeconds(spaceship.shotDelay);
        }
    }
	


	// ぶつかった瞬間に呼び出される
	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "Bullet"){ // ぶつかったオブジェクトの判別

            Destroy(col.gameObject);

            // 爆発する
            exp.Explosion();
			Destroy(gameObject);
		}
	}
}