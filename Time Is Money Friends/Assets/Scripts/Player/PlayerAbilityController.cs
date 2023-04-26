using System.Collections;
using System.Collections.Generic;
using TIM.Core.Abilities;
using TIM.Core.UI;
using UnityEngine;

namespace TIM.Player
{
    public class PlayerAbilityController : MonoBehaviour
    {
        [SerializeField]
        private AbilityScriptableObject primaryAbility;
        private AbilityScriptableObject PrimaryAbility => primaryAbility;

        private void Awake()
        {
            UIController.Instance.AbilityPanel.UpdateImage(PrimaryAbility.AbilityImage, Slot.Primary);
        }

        private void Update()
        {
            if (Input.GetButtonDown("Fire"))
            {
                UseAbility(PrimaryAbility);
            }
        }

        private void UseAbility(AbilityScriptableObject ability)
        {
            switch (ability.AbilityType)
            {
                case Core.AbilityType.Projectile:
                    FireProjectile(ability);
                    break;
                case Core.AbilityType.AoE:
                    break;
                case Core.AbilityType.ProjectileAoE:
                    break;
                case Core.AbilityType.Cone:
                    break;
                default:
                    break;
            }
        }

        private void FireProjectile(AbilityScriptableObject ability)
        {
            GameObject projectile = Instantiate(ability.AbilityPrefab, transform.position, Quaternion.identity);
        }
    }
}
