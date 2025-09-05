using UnityEngine;
using UnityEngine.UIElements;

public class BattleUIManager : MonoBehaviour
{
    VisualElement rootObj;
    Label timeValueLabel;

    private void Start()
    {
        var doc = GetComponent<UIDocument>();
        var root = doc.rootVisualElement;

        rootObj = root.Q<VisualElement>("root");
        timeValueLabel = root.Q<Label>("TimeValue");

        // �Q�[���N���AUI�̔�\��
        rootObj.style.display = DisplayStyle.None;
    }

    // �Q�[���N���AUI��\�����܂���[
    public void ShowGameClear()
    {
        // �Q�[���N���AUI�̕\��
        rootObj.style.display = DisplayStyle.Flex;

        // ����̌o�ߎ��Ԃ�ݒ�
        timeValueLabel.text = 0.ToString();
    }
}
