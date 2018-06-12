using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour {
    public float MoveSpeed = 10f;
    public float RotateSpeed = 40f;

    private CharacterController controller;

    public Animation anim;

    private int count;
    public Text CountText;
    public Text TimerText;
    private float startTime;
    private bool finished = false;
    public Text Wintext;


    void Start () {
        controller = GetComponent<CharacterController>();
        count = 0;
        SetCountText();
        startTime = Time.time;
        Wintext.text = "";
    }
	
	void Update () {
        Move();

        if (controller.velocity.magnitude > 0)
        {
            anim.Play("assault_combat_run");
        }
        else
        {
            anim.Play("assault_combat_idle");
        }

    }
    void Move()
    {

        float movementZ = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
        float movementX = Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime;

        float rotationY = Input.GetAxis("Mouse X") * RotateSpeed * Time.deltaTime;

        transform.Rotate(0f, rotationY, 0f);

        Vector3 forwarMovement = transform.forward * movementZ;
        Vector3 sideMovement = transform.right * movementX;

        Vector3 movement = new Vector3(movementX, 0, movementZ);

        controller.Move(forwarMovement + sideMovement);

        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            controller.Move((forwarMovement*2) + (sideMovement*2));
        }

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }

        if (other.gameObject.CompareTag("Plus"))
        {
            other.gameObject.SetActive(false);
            count = count + 3;
            SetCountText();
        }

        if (count >= 10)
        {
            float t = Time.time - startTime;
            if (t <= 180.0f)
            {
                if (other.gameObject.CompareTag("Finis"))
                {
                    Application.LoadLevel("Bonus Level 2");
                }
            }
            else if (other.gameObject.CompareTag("Finis"))
            {
                other.gameObject.SetActive(false);
                Application.LoadLevel("Level 2");
            }
            if (count >= 279)
            {
                Application.LoadLevel("Level 3");
            }
            else if (other.gameObject.CompareTag("Fini"))
            {
                other.gameObject.SetActive(false);
                load();
            }
            else if (other.gameObject.CompareTag("Fin"))
            {
                other.gameObject.SetActive(false);
                Load();
            }
            else if (other.gameObject.CompareTag("End"))
            {
                other.gameObject.SetActive(false);
                Wintext.text = "You Win";
                Application.LoadLevel("menu");
            }
            else if (Application.loadedLevelName == "Bonus Level 2")
            {
                if (t >= 100.0f)
                {
                    Application.LoadLevel("Level 3");
                }
            }
        }
    }

    public void SetCountText()
    {
        CountText.text = "Score :" + count.ToString();
    }
    public void load()
    {
        Application.LoadLevel("Level 4");
    }
    public void Load()
    {
        Application.LoadLevel("Level 3");
    }
}
