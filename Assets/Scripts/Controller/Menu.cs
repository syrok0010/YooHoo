using UnityEngine;

namespace Controller
{
    public class Menu : MonoBehaviour
    {
        [SerializeField]private GameObject startButton;
        [SerializeField]private GameObject character;
        private void Awake()
        {
            EventAggregator.GameStart += OnGameStart;
        }

        private void OnGameStart()
        {
            startButton.SetActive(false);
            character.SetActive(true);
        }
    }
}
