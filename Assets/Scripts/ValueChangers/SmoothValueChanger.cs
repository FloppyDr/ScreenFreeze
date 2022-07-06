using UnityEngine;
using UnityEngine.Events;

using DG.Tweening;

using ScreenFreeze.Data;
using ScreenFreeze.Proxies;

namespace ScreenFreeze.ValueChangers
{
    public class SmoothValueChanger : MonoBehaviour
    {
        [SerializeField]
        private BaseProxy _proxy;

        [SerializeField]
        private SmoothValueChangeData _smoothValueChangeData;

        [SerializeField]
        private UnityEvent _increased;
        
        [SerializeField]
        private UnityEvent _decreased;

        private Tween _changeValueTween;

        public void IncreaseValue()
        {
            ChangeValue(_smoothValueChangeData.MaxValue, _smoothValueChangeData.Duration, _increased);
        }

        public void DecreaseValue()
        {
            ChangeValue(_smoothValueChangeData.MinValue, _smoothValueChangeData.Duration, _decreased);
        }

        public void EndChanging()
        {
            _changeValueTween?.Kill();
        }

        private void ChangeValue(float endValue, float duration, UnityEvent completed)
        {
            EndChanging();

            _changeValueTween = DOVirtual.Float(_proxy.GetValue(), endValue, duration,
                value => _proxy.SetValue(value));
            _changeValueTween.OnComplete(() => completed?.Invoke());
        }
    }
}
