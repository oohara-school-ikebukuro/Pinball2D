using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class EnemyTarget : MonoBehaviour
{
    [SerializeField] private GameObject root;

    // �{�[��������������A���O���o����
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Debug.Log("�Ȃ񂩓���������");

        // �{�[��������������A�W���[�W������
        Destroy(root);
    }
}
