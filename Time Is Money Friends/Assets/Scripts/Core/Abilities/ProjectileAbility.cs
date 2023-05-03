using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIM.Core
{
    public class ProjectileAbility : AbstractAbility
    {
        [SerializeField]
        private SpriteRenderer spriteRenderer;
        public SpriteRenderer SpriteRenderer => spriteRenderer;

        private void OnCollisionEnter2D(Collision2D other)
        {
            other.gameObject.SendMessage("abilityCollision", AbilityData, SendMessageOptions.DontRequireReceiver);
            if (DestroyOnContact)
            {
                Destroy(gameObject);
            }
        }

        private void Update()
        {
            transform.position += transform.up * Speed * Time.deltaTime;
        }
    }
}
