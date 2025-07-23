using UnityEngine;
using UnityEngine.UI;

public class Startup : MonoBehaviour
{
    [SerializeField] private Button characterButtonPrefab;

    private void Awake()
    {
        var defaultFactory = new SimpleCharacterFactory();
        var abstractFactory = new CharacterAbstractFactory(defaultFactory);

        ServiceLocator.Register<ICharacterAbstractFactory>(abstractFactory);

        var buttonAbstractFactory = new ButtonAbstractFactory();
        var characterButtonFactory = new CharacterButtonFactory(characterButtonPrefab);
        buttonAbstractFactory.RegisterFactory(characterButtonFactory);

        ServiceLocator.Register<IButtonAbstractFactory>(buttonAbstractFactory);

    }

    private void OnDestroy()
    {
        ServiceLocator.Unregister<ICharacterAbstractFactory>();
        ServiceLocator.Unregister<IButtonAbstractFactory>();

    }
}
