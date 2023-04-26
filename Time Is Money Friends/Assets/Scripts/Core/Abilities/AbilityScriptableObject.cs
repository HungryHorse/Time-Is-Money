using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIM.Core.Abilities
{
    using UnityEngine;

    [CreateAssetMenu(fileName = "AbilityScriptableObject", menuName = "Time Is Money Friends/AbilityScriptableObject", order = 0)]
    public class AbilityScriptableObject : ScriptableObject
    {
        [SerializeField]
        private string abilityName;
        public string AbilityName => abilityName;

        [SerializeField]
        private GameObject abilityPrefab;
        public GameObject AbilityPrefab => abilityPrefab;

        [SerializeField]
        private Sprite abilityImage;
        public Sprite AbilityImage => abilityImage;

        [SerializeField]
        private AbilityAttribute attribute;
        public AbilityAttribute Attribute => attribute;

        [SerializeField]
        private AbilityType abilityType;
        public AbilityType AbilityType => abilityType;

        [SerializeField]
        private float speed;
        public float Speed => speed;

        [SerializeField]
        private Slot slot;
        public Slot Slot => slot;

        [SerializeField]
        private int damage;
        public int Damage => damage;
    }
}
