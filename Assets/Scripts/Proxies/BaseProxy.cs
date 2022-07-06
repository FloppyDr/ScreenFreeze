using UnityEngine;

using ScreenFreeze.Interfaces;

namespace ScreenFreeze.Proxies
{
    public class BaseProxy : MonoBehaviour, IValueProxy
    {
        public virtual float GetValue()
        {
            return default;
        }

        public virtual void SetValue(float value) {}
    }
}
