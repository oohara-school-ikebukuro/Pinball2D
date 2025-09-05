using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class EnemyTarget : MonoBehaviour
{

    // ボールが当たったら、ログを出すよ
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Debug.Log("なんか当たったな");

        // ボールが当たったら、ジョージ消して
        Destroy(gameObject);
    }
}
