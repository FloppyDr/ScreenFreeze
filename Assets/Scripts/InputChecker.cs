using UnityEngine;
using UnityEngine.Events;

namespace ScreenFreeze
{
    public class InputChecker : MonoBehaviour
    {
        [SerializeField] private UnityEvent _inputDetected;
   
        private Vector3 lastMousePosition;

        private void Awake()
        {
            lastMousePosition = Input.mousePosition;
        }

        private void Update()
        {
            if (Input.anyKeyDown || Input.touchCount > 0 || IsMouseMoved())
            {
                _inputDetected?.Invoke();
            }
        }

        private bool IsMouseMoved()
        {
            var mouseDelta = Input.mousePosition - lastMousePosition;
            lastMousePosition = Input.mousePosition;
        
            return mouseDelta != Vector3.zero;
        }
    }
}