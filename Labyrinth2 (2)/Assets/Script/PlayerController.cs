using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 18;
    private float rotationSpeed = 1f;
    private Rigidbody rig;

    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = PlayerPrefs.GetFloat("Sans");
        rig = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rig.freezeRotation = false;
        rig.rotation = Quaternion.Euler(rig.rotation.eulerAngles + new Vector3(0f, rotationSpeed * Input.GetAxis("Mouse X"), 0f));
        rig.freezeRotation = true;

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(hAxis, 0, vAxis) * speed * Time.deltaTime;

        rig.velocity = rig.rotation * movement;
        Mathf.Clamp(rig.rotation.eulerAngles.x, -70, 70);
        Mathf.Clamp(rig.rotation.eulerAngles.y, -70, 70);


    }
}
