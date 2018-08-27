using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCtrl : MonoBehaviour {

    private Rigidbody2D rb2d;
    private int Count;

    public Text CountText;
    public Text WinText;
    public float speed;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Count = 0;
        setCountText();
        WinText.text = "";
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveX, moveY);
        rb2d.AddForce(movement * speed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("collectable")) {
            other.gameObject.SetActive(false);
            //Count++;
            Count = Count + 1;
            setCountText();
            //change to value when I have more collectables
        }
    }

    void setCountText ()
    {
        CountText.text = "Score: " + Count.ToString();
        if (Count >= 10)
        {
            WinText.text = "You Win!!";
        }
    }

}
