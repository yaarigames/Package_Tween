using UnityEngine;

namespace SAS.TweenManagement
{
    sealed class AnchoredPositionTween : V3TweenMonoBase
    {
        public override void Play(OnAnimationCompleteCallback ontweenCompleted)
        {
            base.Play(ontweenCompleted);
            Tween.Move(_transform as RectTransform, m_from, m_To, m_ParamConfig.value);
        }

        protected override void Reset()
        {
            (_transform as RectTransform).SetPosition(m_from);
        }
    }
}
