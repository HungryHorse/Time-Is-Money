using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIM.Player
{
    public class PlayerTargetController : MonoBehaviour
    {
        private const float BaseRotation = 45f;

        [SerializeField]
        private Transform playerTransform;
        private Transform PlayerTransform => playerTransform;

        [SerializeField]
        private float distanceFromPlayer;
        private float DistanceFromPlayer => distanceFromPlayer;

        private Camera MouseCamera { get; set; }

        private Vector3 mousePos;
        private float angle;
        private Vector3 targetPos;
        private Vector2 mouseWorldPos;
        private Vector2 playerWorldPos;

        private void Start()
        {
            MouseCamera = Camera.main;
        }

        // Update is called once per frame
        void Update()
        {
            mousePos = Input.mousePosition;
            targetPos = MouseCamera.WorldToScreenPoint(PlayerTransform.position);
            mouseWorldPos = MouseCamera.ScreenToWorldPoint(mousePos);
            playerWorldPos = PlayerTransform.position;

            float distanceFromMouse = Vector2.Distance(mouseWorldPos, PlayerTransform.position);
            float targetDistance = Mathf.Min(DistanceFromPlayer, distanceFromMouse);
            transform.position = playerWorldPos + ((mouseWorldPos - playerWorldPos).normalized * targetDistance);

            mousePos.x -= targetPos.x;
            mousePos.y -= targetPos.y;
            angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(Vector3.forward * (angle - BaseRotation));
        }
    }
}
