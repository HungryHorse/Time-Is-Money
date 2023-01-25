using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTargetController : MonoBehaviour
{
    private const float BaseRotation = 45f;

    [SerializeField]
    private float rotationSpeed;
    private float RotationSpeed => rotationSpeed;

    [SerializeField]
    private Transform playerTransform;
    private Transform PlayerTransform => playerTransform;

    private Camera MouseCamera { get; set; }

    private Vector3 mousePos;
    private float angle;
    private Vector3 targetPos;

    private void Start()
    {
        MouseCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition;
        targetPos = MouseCamera.WorldToScreenPoint(transform.position);
        mousePos.x -= targetPos.x;
        mousePos.y -= targetPos.y;
        angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(Vector3.forward * (angle - BaseRotation));
    }
}
