using UnityEngine;

namespace Controller
{
    public class CleanerACounter : MonoBehaviour
    {
        public static int Score { get; private set;}

        private void OnTriggerEnter2D(Collider2D other)
        {
            Destroy(other.gameObject);
            Score++;
        }
    }
}
