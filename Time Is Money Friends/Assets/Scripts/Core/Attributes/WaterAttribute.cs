using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIM.Core
{
    public class WaterAttribute : IAttribute
    {
        public States PossibleStates => States.Solid | States.Liquid;

        public bool DoesProduceHeat { get; private set; } = false;
        public bool DoesProduceCold { get; private set; } = true;

        public void OnHitAttribute(IAttribute attribute)
        {
            throw new System.NotImplementedException();
        }
    }
}
