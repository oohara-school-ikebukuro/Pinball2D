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

        // ゲームクリアUIの非表示
        root.style.display = DisplayStyle.None;
    }

    // ゲームクリアUIを表示しますよー
    public void ShowGameClear()
    {
        // ゲームクリアUIの表示
        root.style.display = DisplayStyle.Flex;

        // 今回の経過時間を設定
        timeValueLabel.text = 0.ToString();
    }
}
