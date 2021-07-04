using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private CharacterController characterController;
    private Vector3 Velocity;

    [SerializeField]
    private float JumpPower = 8;

    [SerializeField]
    private float MoveSpeed = 10;

    public float sensitivityX = 15f;
    public float sensitivityY = 15f;

    public float minimunX = -360f;
    public float maximunX = 360f;

    public float minimumY = -60f;
    public float maximunY = 60f;

    float rotationX = 0f;
    float rotationY = 0f;

    public GameObject VerRot;
    public GameObject HorRot;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;

        rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
        rotationY = Mathf.Clamp(rotationY, minimumY, maximunY);

        VerRot.transform.localEulerAngles = new Vector3(-rotationY, 0, 0);
        HorRot.transform.localEulerAngles = new Vector3(0, rotationX, 0);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            characterController.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            characterController.Move(this.gameObject.transform.forward * -1f * MoveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            characterController.Move(this.gameObject.transform.right * -1f * MoveSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            characterController.Move(this.gameObject.transform.right * MoveSpeed * Time.deltaTime);
        }

        characterController.Move(Velocity * Time.deltaTime);

        Velocity.y += Physics.gravity.y * Time.deltaTime;

        if (characterController.isGrounded)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Velocity.y = JumpPower;
            }
        }
    }
}
