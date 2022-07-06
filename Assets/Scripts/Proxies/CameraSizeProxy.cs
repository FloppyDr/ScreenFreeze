using UnityEngine;

namespace ScreenFreeze.Proxies
{
    public class CameraSizeProxy : BaseProxy
    {
        [SerializeField] private UnityEngine.Camera _camera;
    
        public override float GetValue()
        {
            return _camera.orthographicSize;
        }

        public override void SetValue(float value)
        {
            _camera.orthographicSize = value;
        }
    }
}