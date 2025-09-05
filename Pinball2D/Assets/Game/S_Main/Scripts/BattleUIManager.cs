using UnityEngine;
using UnityEngine.UIElements;

public class BattleUIManager : MonoBehaviour
{
    VisualElement root;
    Label timeValueLabel;

    private void Start()
    {
        var doc = GetComponent<UIDocument>();

        root = doc.rootVisualElement;
        timeValueLabel = root.Q<Label>("TimeValue");

        // �Q�[���N���AUI�̔�\��
        root.style.display = DisplayStyle.None;
    }

    // �Q�[���N���AUI��\�����܂���[
    public void ShowGameClear()
    {
        // �Q�[���N���AUI�̕\��
        root.style.display = DisplayStyle.Flex;

        // ����̌o�ߎ��Ԃ�ݒ�
        timeValueLabel.text = 0.ToString();
    }
}
