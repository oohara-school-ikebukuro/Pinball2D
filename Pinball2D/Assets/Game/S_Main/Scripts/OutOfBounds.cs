using UnityEngine;

// BoxCollider2D ����Ȃ��A Collider2D �ŋ������邱�Ƃ��\
[RequireComponent(typeof(Collider2D))]
public class OutOfBounds : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;

    private void Start()
    {
        // �����蔻����s����ł����A��������͍s��Ȃ���
        var col = GetComponent<Collider2D>();
        col.isTrigger = true;

        // ���X�|�[���`�������
        respawnPoint.gameObject.SetActive(false);
    }

    // �����蔻������Ȃ��Ȃ����Ώۂ�����Δ��΂���
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(!collision.CompareTag("Ball"))
        {
            return;
        }
        // Debug.Log("�{�[�����A�E�����܂���");

        // �{�[���̈ʒu���A���|�b�v�ʒu�ɏC�����܂�
        collision.transform.position = respawnPoint.position;

        // RigidBody���擾
        var rb = collision.attachedRigidbody;
        // ���x�����Z�b�g���܂���B
        if (rb != null) rb.linearVelocity = Vector2.zero;
    }
}
