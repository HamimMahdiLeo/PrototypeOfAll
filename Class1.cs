using UnityEngine;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float sprintSpeed = 9f;
    public float jumpForce = 7f;
    public float gravity = -9.81f;

    public float maxStamina = 100f;
    public float currentStamina;
    public float staminaDrainRate = 30f;
    public float staminaRechargeRate = 10f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundLayer;

    private CharacterController controller;
    private Vector3 velocity;
    private bool isGrounded;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        currentStamina = maxStamina;

        // Auto set groundLayer to everything except Player (layer 8) if not assigned
        if (groundLayer.value == 0)
        {
            groundLayer = ~(1 << 8);
        }
    }

    void Update()
    {
        // Ground Check
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundLayer);

        if (isGrounded && velocity.y < 0)
            velocity.y = 0f;

        // Sprint and stamina
        bool isSprinting = Input.GetKey(KeyCode.LeftShift) && currentStamina > 0 && Input.GetAxis("Vertical") > 0;
        float currentSpeed = isSprinting ? sprintSpeed : speed;

        if (isSprinting)
        {
            currentStamina -= staminaDrainRate * Time.deltaTime;
            currentStamina = Mathf.Clamp(currentStamina, 0, maxStamina);
        }
        else if (currentStamina < maxStamina)
        {
            currentStamina += staminaRechargeRate * Time.deltaTime;
            currentStamina = Mathf.Clamp(currentStamina, 0, maxStamina);
        }

        // Movement input
        Vector3 move = transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical");
        controller.Move(move * currentSpeed * Time.deltaTime);

        // Jump
        if (Input.GetButtonDown("Jump") && isGrounded)
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);

        // Gravity
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}