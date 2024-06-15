using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 1f;
    public int score=0;
    public TextMeshProUGUI text;
    public AudioSource goatSound;
    public AudioClip[] clip;
    float timer = 5;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if(timer>0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            Debug.Log("time out");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ButtonJump();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Pipe")|| collision.gameObject.CompareTag("Ground"))
        {
            
           goatSound.PlayOneShot(clip[0]);

            Time.timeScale = 0;
            StartCoroutine(Freeze());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Points"))
        {
           
            score++;
            text.text = score.ToString();
            goatSound.PlayOneShot(clip[1]);
        }
    }
    public void ButtonJump()
    {
        rb.gravityScale = 1;
        rb.velocity = Vector2.up * speed;
    }


    IEnumerator Freeze()
    {
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene("Restart");
        
    }


}
