using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public bool jump = false;
    public bool slide = false;

    public GameObject trigger;
    public Animator anim;

    public float score = 0;
    public Text scoreText;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        scoreText.text = score.ToString();

        if (score > 100)
        {
            transform.Translate(0, 0, 0.13f);
        }
        else if(score >= 200)
        {
            transform.Translate(0, 0, 0.19f);
        }
        else
        {
            transform.Translate(0, 0, 0.1f);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            jump = true;
        }
        else
        {
            jump = false;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            slide = true;
        }
        else
        {
            slide = false;
        }

        if (jump == true)
        {
            anim.SetBool("isJump", jump);
            transform.Translate(0, 0f, 0.1f);
        } 
        else if(jump == false)
        {
            anim.SetBool("isJump", jump);
        }

        if (slide == true)
        {
            anim.SetBool("isSlide", slide);
            transform.Translate(0, 0, 0.1f);
        }
        else if (slide == false)
        {
            anim.SetBool("isSlide", slide);
        }

        trigger = GameObject.FindGameObjectWithTag("Obstacle");
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PlayerTrigger")
        {
            Destroy(trigger.gameObject);
        }
        if(other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject, 0.5f);
            score += 5f;
        }
    }
}
