using UnityEngine;
using UnityEngine.UI;

namespace ScreenFreeze.Proxies
{
    public class ImageAlphaProxy : BaseProxy
    {
        [SerializeField]
        private Image _image;

        private Color _cachedColor;

        private void Awake()
        {
            _cachedColor = _image.color;
        }

        public override float GetValue()
        {
            return _cachedColor.a;
        }

        public override void SetValue(float value)
        {
            _cachedColor.a = value;

            _image.color = _cachedColor;
        }
    }
}
