using System.Collections;
using System.Collections.Generic;
using TIM.Core;
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

        [SerializeField]
        private AbilityScriptableObject qAbility;
        private AbilityScriptableObject QAbility => qAbility;

        [SerializeField]
        private AbilityScriptableObject eAbility;
        private AbilityScriptableObject EAbility => eAbility;

        private void Start()
        {
            UIController.Instance.AbilityPanel.UpdateImage(PrimaryAbility?.AbilityImage, Slot.Primary);
            UIController.Instance.AbilityPanel.UpdateImage(QAbility?.AbilityImage, Slot.Q);
            UIController.Instance.AbilityPanel.UpdateImage(EAbility?.AbilityImage, Slot.E);
        }

        private void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                UseAbility(PrimaryAbility);
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                UseAbility(QAbility);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                UseAbility(EAbility);
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
            ProjectileAbility projectile = Instantiate((ProjectileAbility)ability.AbilityPrefab, transform.position, transform.rotation);
            projectile.Init(ability);
        }
    }
}
