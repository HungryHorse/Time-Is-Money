using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIM.Player
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField]
        private float basePlayerSpeed = 5f;
        private float BasePlayerSpeed => basePlayerSpeed;

        [SerializeField]
        private Animator animator;
        private Animator Animator => animator;

        public float PlayerSpeedMultiplier { get; set; } = 1;

        private float PlayerSpeed { get => BasePlayerSpeed * PlayerSpeedMultiplier; }

        private float horizontalInput;
        private float verticalInput;
        private Vector3 moveVector;

        // Update is called once per frame
        void Update()
        {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");

            Animator.SetBool("isMoving", Mathf.Abs(horizontalInput) >= 0.1f || Mathf.Abs(verticalInput) >= 0.1f);

            moveVector = Vector2.ClampMagnitude(((Vector2.right * horizontalInput) + (Vector2.up * verticalInput)), 1);

            transform.position += moveVector * PlayerSpeed * Time.deltaTime;
        }
    }
}
