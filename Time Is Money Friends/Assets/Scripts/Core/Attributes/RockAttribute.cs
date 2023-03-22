using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIM.Core
{
    public class RockAttribute : IAttribute
    {
        public States PossibleStates => States.Solid | States.Liquid;

        public bool DoesProduceHeat { get; private set; } = false;
        public bool DoesProduceCold { get; private set; } = false;

        public void OnHitAttribute(IAttribute attribute)
        {
            throw new System.NotImplementedException();
        }
    }
}
