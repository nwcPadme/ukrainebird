using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    public float force;
    private Rigidbody2D _bird;
    public GameObject restartButton;
    public AudioSource music;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        _bird = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKey(KeyCode.Space))
        {
            _bird.velocity = Vector2.up * force;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag == "Enemy")
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            restartButton.SetActive(true);
            music.Stop();
        }
    }
}
