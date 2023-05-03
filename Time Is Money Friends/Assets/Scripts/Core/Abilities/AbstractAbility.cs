using System.Collections;
using System.Collections.Generic;
using TIM.Core.Abilities;
using UnityEngine;

namespace TIM.Core
{
    public abstract class AbstractAbility : MonoBehaviour
    {
        public AbilityScriptableObject AbilityData { get; set; }

        public float Speed { get; set; }

        public bool DestroyOnContact { get; set; } = true;

        public virtual void Init(AbilityScriptableObject abilityData)
        {
            AbilityData = abilityData;
            Speed = abilityData.Speed;
        }
    }
}
