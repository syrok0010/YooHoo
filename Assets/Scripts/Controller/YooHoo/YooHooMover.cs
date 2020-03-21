using UnityEngine;

namespace Controller.YooHoo
{
    public class YooHooMover : MonoBehaviour
    {
        private Vector2 _startPosition;
        private Vector2 _nextPosition;
        private float _progress;
        [SerializeField][Range(0, 1)] private float step;
        private void FixedUpdate()
        {
            _startPosition = gameObject.transform.localPosition;
            if (Input.touchCount != 1) return;
            var touch = Input.GetTouch(0);
            _nextPosition = Camera.main.ScreenToWorldPoint(touch.position);
            _nextPosition.y = _startPosition.y;
            transform.position = Vector2.Lerp(_startPosition, _nextPosition, _progress);
            transform.localScale = Vector3.Scale(transform.localScale, _nextPosition.x - _startPosition.x > 3 ? new Vector3(1,1,1) : new Vector3(-1,1,1));

            
            _progress += step;
        }
    }
}
