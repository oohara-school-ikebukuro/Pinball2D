using UnityEngine;

public class BattleManager : MonoBehaviour
{
    // �G�̓I�������Ă���ATransform
    [SerializeField] private Transform enemyTargets;

    bool isGameEnd = false;

    private void Update()
    {
        // �Q�[���I�����́A�������Ȃ��B
        if (isGameEnd) return;

        // �S�I���j�󂳂ꂽ���H
        if(enemyTargets.childCount == 0)
        {
            isGameEnd = true;
            Debug.Log("�S�Ă̓I��j��ł��܂���");
        }
    }
}
