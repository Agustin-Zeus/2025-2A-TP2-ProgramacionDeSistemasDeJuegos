using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Menu/ButtonConfig")]
public class ButtonConfig : ScriptableObject, ISetup<GameObject>
{
    public string Title;
    public CharacterConfig CharacterConfig;

    public void Setup(GameObject go)
    {
        var btn = go.GetComponent<Button>() ?? go.AddComponent<Button>();

        var tmp = go.GetComponentInChildren<TextMeshProUGUI>();
        if (tmp != null)
        {
            tmp.text = Title;
        }
        else
        {
            var txt = go.GetComponentInChildren<Text>();
            if (txt != null)
                txt.text = Title;
            else
                Debug.LogWarning($"ButtonConfigSO: not found TMP in {go.name}");
        }

        btn.onClick.RemoveAllListeners();
    }
}