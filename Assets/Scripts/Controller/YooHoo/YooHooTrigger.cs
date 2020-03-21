using UnityEngine;

namespace Controller.YooHoo
{
    public class YooHooTrigger : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            EventAggregator.OnGameOver(false);
        }
    }
}
