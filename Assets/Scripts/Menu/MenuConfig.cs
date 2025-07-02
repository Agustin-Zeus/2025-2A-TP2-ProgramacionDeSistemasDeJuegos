using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Menu/MenuConfigSO")]
public class MenuConfig : ScriptableObject
{
    [Serializable]
    public class ButtonEntry
    {
        public string Title;
        public CharacterConfig CharacterConfig;
    }

    public List<ButtonEntry> Buttons;
}