using UnityEngine;

namespace Nekton
{
    public class PlayerController2D : MonoBehaviour
    {
        [Header("Movement")]
        public float moveSpeed = 5f;
        public float dashSpeed = 9f;
        public float dashDuration = 0.15f;
        public float dashCooldown = 0.5f;

        private Rigidbody2D rb;
        private Vector2 moveInput;
        private bool isDashing;
        private float dashTimer;
        private float dashCooldownTimer;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

            if (Input.GetKeyDown(KeyCode.LeftShift) && !isDashing && dashCooldownTimer <= 0f)
            {
                StartDash();
            }

            if (dashCooldownTimer > 0f)
            {
                dashCooldownTimer -= Time.deltaTime;
            }
        }

        private void FixedUpdate()
        {
            if (isDashing)
            {
                rb.velocity = moveInput * dashSpeed;
                dashTimer -= Time.fixedDeltaTime;

                if (dashTimer <= 0f)
                {
                    isDashing = false;
                }
            }
            else
            {
                rb.velocity = moveInput * moveSpeed;
            }
        }

        private void StartDash()
        {
            isDashing = true;
            dashTimer = dashDuration;
            dashCooldownTimer = dashCooldown;
        }
    }
}
