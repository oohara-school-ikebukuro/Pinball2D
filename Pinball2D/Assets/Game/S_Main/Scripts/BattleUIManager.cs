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

        // ゲームクリアUIの非表示
        rootObj.style.display = DisplayStyle.None;
    }

    // ゲームクリアUIを表示しますよー
    public void ShowGameClear()
    {
        // ゲームクリアUIの表示
        rootObj.style.display = DisplayStyle.Flex;

        // 今回の経過時間を設定
        timeValueLabel.text = 0.ToString();
    }
}
