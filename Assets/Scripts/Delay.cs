using System.Collections;

using UnityEngine;
using UnityEngine.Events;

namespace ScreenFreeze
{
    public class Delay : MonoBehaviour
    {
        [SerializeField] private UnityEvent _delayEnded;
        [SerializeField] private float _delay;
   
        private Coroutine _delayingCoroutine;

        private void Start()
        {
            BeginAction();
        }

        public void BeginAction()
        {
            StopDelaying();

            _delayingCoroutine = StartCoroutine(Delaying());
        }

        public void EndAction()
        {
            StopDelaying();
        }

        private void StopDelaying()
        {
            if(_delayingCoroutine == null) return;
            
            StopCoroutine(_delayingCoroutine);
            _delayingCoroutine = null;
        }

        private IEnumerator Delaying()
        {
            yield return new WaitForSeconds(_delay);
            
            _delayEnded?.Invoke();
            _delayingCoroutine = null;
        }
    }
}
