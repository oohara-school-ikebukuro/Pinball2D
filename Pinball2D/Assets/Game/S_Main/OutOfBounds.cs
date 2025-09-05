using UnityEngine;

// BoxCollider2D じゃなく、 Collider2D で強制することも可能
[RequireComponent(typeof(Collider2D))]
public class OutOfBounds : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;

    private void Start()
    {
        // 当たり判定を行うんですが、物理判定は行わないよ
        var col = GetComponent<Collider2D>();
        col.isTrigger = true;

        // リスポーン描画を消す
        respawnPoint.gameObject.SetActive(false);
    }

    // 当たり判定をしなくなった対象がいれば発火する
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(!collision.CompareTag("Ball"))
        {
            return;
        }
        // Debug.Log("ボールが、脱走しました");

        // ボールの位置を、リポップ位置に修正します
        collision.transform.position = respawnPoint.position;

        // RigidBodyを取得
        var rb = collision.attachedRigidbody;
        // 速度をリセットしますよ。
        if (rb != null) rb.linearVelocity = Vector2.zero;
    }
}
