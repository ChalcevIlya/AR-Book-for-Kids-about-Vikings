using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputControl : MonoBehaviour
{

    public Joystick joystick;

    public Text countText;
    public int count;
    public Text vopr1, vopr2, vopr3, vopr4;
    public Button b11, b12, b13, b14, b21, b22, b23, b24, b31, b32, b33, b34, b41, b42, b43, b44;

    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        count = 0;
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        var rb = GetComponent<Rigidbody>();

        rb.velocity = new Vector3(joystick.Horizontal * 5f, rb.velocity.y, joystick.Vertical * 5f);
        if (rb.velocity.x != 0 && rb.velocity.z != 0)
        {
            transform.LookAt(rb.velocity + transform.position);
            transform.Rotate(-90, 0, -90, Space.Self);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collect1"))
        {
            other.gameObject.SetActive(false);
            vopr1.gameObject.SetActive(true);
            b11.gameObject.SetActive(true);
            b12.gameObject.SetActive(true);
            b13.gameObject.SetActive(true);
            b14.gameObject.SetActive(true);
            count++;
            SetCountText();
        }
        else if (other.gameObject.CompareTag("Collect2"))
        {
            other.gameObject.SetActive(false);
            vopr2.gameObject.SetActive(true);
            b21.gameObject.SetActive(true);
            b22.gameObject.SetActive(true);
            b23.gameObject.SetActive(true);
            b24.gameObject.SetActive(true);
            count++;
            SetCountText();
        }
        else if (other.gameObject.CompareTag("Collect3"))
        {
            other.gameObject.SetActive(false);
            vopr3.gameObject.SetActive(true);
            b31.gameObject.SetActive(true);
            b32.gameObject.SetActive(true);
            b33.gameObject.SetActive(true);
            b34.gameObject.SetActive(true);
            count++;
            SetCountText();
        }
        else if (other.gameObject.CompareTag("Collect4"))
        {
            other.gameObject.SetActive(false);
            vopr4.gameObject.SetActive(true);
            b41.gameObject.SetActive(true);
            b42.gameObject.SetActive(true);
            b43.gameObject.SetActive(true);
            b44.gameObject.SetActive(true);
            count++;
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "Collected " + count.ToString() + "/4";
    }
}
