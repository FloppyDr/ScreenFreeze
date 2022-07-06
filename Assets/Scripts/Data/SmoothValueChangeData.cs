using UnityEngine;

namespace ScreenFreeze.Data
{
    [CreateAssetMenu(fileName = "SmoothValueChangeData", menuName = "ValueChange/SmoothValueChangeData")]
    public class SmoothValueChangeData : ScriptableObject
    {
        public float Duration => _duration;
        public float MinValue => _minValue;
        public float MaxValue => _maxValue;
        
        [SerializeField] private float _duration;
        [SerializeField] private float _minValue;
        [SerializeField] private float _maxValue;
    }
}