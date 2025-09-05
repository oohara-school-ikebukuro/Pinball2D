using UnityEngine;

public class BattleManager : MonoBehaviour
{
    // 敵の的が入っている、Transform
    [SerializeField] private Transform enemyTargets;

    bool isGameEnd = false;

    private void Update()
    {
        // ゲーム終了時は、処理しない。
        if (isGameEnd) return;

        // 全的が破壊されたか？
        if(enemyTargets.childCount == 0)
        {
            isGameEnd = true;
            Debug.Log("全ての的を破壊できました");
        }
    }
}
