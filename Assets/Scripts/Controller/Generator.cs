using System.Collections;
using Random = UnityEngine.Random;
using UnityEngine;

namespace Controller
{
    public class Generator : MonoBehaviour
    {

        private static readonly GameObject[] Obstacles = new GameObject[40];
        private static readonly GameObject[] Prefabs = new GameObject[40];
        private static int _num;
        [SerializeField] [Range(0f, 1f)] private float timeInInspector;
        private static float _time;

        private void Awake()
        {
            EventAggregator.GameStart += StartGeneration;
            _time = timeInInspector;
        }
        
        private static void Fill()
        {
            for (var i = 0; i <= 33; i++)
            {
                Prefabs[i] = Resources.Load("Prefabs/Food/" + i) as GameObject;
                if (Prefabs[i] == null) Debug.Log("That's not working");
            }
        }

        private void StartGeneration()
        {
            Fill();
            StartCoroutine(GeneratorFood());
        }

        private static IEnumerator GeneratorFood()
        {
            while (CleanerACounter.Score < 1000)
            {
                var item = Random.Range(1, 33);
                var position = new Vector3(Random.Range(-1.0f, 1.0f) * 8.58f, 5.3f);
                Obstacles[_num] = Instantiate(Prefabs[item], position, new Quaternion());
                Obstacles[_num].AddComponent<Rigidbody2D>();
                Obstacles[_num].AddComponent<BoxCollider2D>();
                Obstacles[_num].tag = "Food";
                _num++;
                if (_num >= 15) _num = 0;
                yield return new WaitForSeconds(_time);
            }
        }

    }
}
