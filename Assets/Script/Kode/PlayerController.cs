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

    public Text bestScoreText;
    public bool death = false;
    public Image gameOverImg;

    public Rigidbody rbody;
    public CapsuleCollider myCollider;

    public float lastScore;

    void Start()
    {
        anim = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody>();
        myCollider = GetComponent<CapsuleCollider>();

        lastScore = PlayerPrefs.GetFloat("MyScore");
        Time.timeScale = 1;
    }

    void Update()
    {

        scoreText.text = score.ToString();

        if (score > lastScore)
        {
            bestScoreText.text = "Best Score : " + score.ToString();
        }
        else
        {
            bestScoreText.text = "Your Score : " + score.ToString();
        }

        if (death == true)
        {
            anim.SetTrigger("isDeath");
            
            gameOverImg.gameObject.SetActive(true);
        }

        if (score > 100 && death != true)
        {
            transform.Translate(0, 0, 0.13f);
        }
        else if(score >= 200 && death != true)
        {
            transform.Translate(0, 0, 0.19f);
        }
        else if (death == true)
        {
            transform.Translate(0, 0, 0);
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
            transform.Translate(0, 0.15f, 0.1f);
            
        } 
        else if(jump == false)
        {
            anim.SetBool("isJump", jump);
        }

        if (slide == true)
        {
            anim.SetBool("isSlide", slide);
            transform.Translate(0, 0, 0.1f);
            myCollider.height = 1.8f;
        }
        else if (slide == false)
        {
            anim.SetBool("isSlide", slide);
            myCollider.height = 2.05f;
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
        if (other.gameObject.tag == "DeathPoint")
        {
            death = true;
            if (score > lastScore)
            {
                PlayerPrefs.SetFloat("MyScore", score);
            }
        }
    }
}
