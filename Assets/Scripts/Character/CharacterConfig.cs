
using UnityEngine;

[CreateAssetMenu(menuName = "Configs/CharacterConfig")]
public class CharacterConfig : ScriptableObject
{
    public Character prefab;
    public CharacterModel characterModel;
    public PlayerControllerModel controllerModel;
    public RuntimeAnimatorController animatorController;
}
