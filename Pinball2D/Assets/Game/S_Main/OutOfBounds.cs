using UnityEngine;

// BoxCollider2D ����Ȃ��A Collider2D �ŋ������邱�Ƃ��\
[RequireComponent(typeof(Collider2D))]
public class OutOfBounds : MonoBehaviour
{
    private void Start()
    {
        // �����蔻����s����ł����A��������͍s��Ȃ���
        var col = GetComponent<Collider2D>();
        col.isTrigger = true;
    }

    // �����蔻������Ȃ��Ȃ����Ώۂ�����Δ��΂���B
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(!collision.CompareTag("Ball"))
        {
            return;
        }

        Debug.Log("�{�[�����A�E�����܂���");
    }
}
