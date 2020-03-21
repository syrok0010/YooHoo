using UnityEngine;

namespace View
{
    public class Menu : MonoBehaviour
    {
        public void OnStartClicked()
        {
            EventAggregator.OnGameStart();
        }
    }
}
