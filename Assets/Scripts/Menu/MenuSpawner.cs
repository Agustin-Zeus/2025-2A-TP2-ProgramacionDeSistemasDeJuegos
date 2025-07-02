using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuSpawner : MonoBehaviour
{
    [SerializeField] private MenuConfig menuConfig;
    [SerializeField] private Button buttonPrefab;
    [SerializeField] private Transform container;

    private void Start()
    {
        var spawner = FindObjectOfType<CharacterSpawner>();
        if (spawner == null)
        {
            Debug.LogError("CharacterSpawner not found in scene.");
            return;
        }

        foreach (var entry in menuConfig.Buttons)
        {
            var buttonGO = Instantiate(buttonPrefab.gameObject, container);
            var btn = buttonGO.GetComponent<Button>();

            var tmp = buttonGO.GetComponentInChildren<TextMeshProUGUI>();
            if (tmp != null) tmp.text = entry.Title;
            else
            {
                var txt = buttonGO.GetComponentInChildren<Text>();
                if (txt != null) txt.text = entry.Title;
            }

            btn.onClick.RemoveAllListeners();
            btn.onClick.AddListener(() => spawner.Spawn(entry.CharacterConfig));
        }
    }
}
