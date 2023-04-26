using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIM.Core
{
    [System.Serializable]
    public class AbilityAttribute
    {
        [SerializeField]
        private States possibleStates;
        public States PossibleStates => possibleStates;

        [SerializeField]
        private bool producesHeat;
        public bool ProducesHeat => producesHeat;

        [SerializeField]
        private bool producesCold;
        public bool ProducesCold => producesCold;
    }
}
