using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIM.Core
{
    public interface IAttribute
    {
        public States PossibleStates { get; }

        public bool DoesProduceHeat { get; }

        public bool DoesProduceCold { get; }

        public void OnHitAttribute(IAttribute attribute);
    }
}
