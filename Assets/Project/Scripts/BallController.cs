using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [Header("Speed and Control of Player")]
    [SerializeField] private bool _isRight;
    [SerializeField] private float speed;
    [SerializeField] private int ponts = 0;
    [SerializeField] private int life;

    [Header("References to objetos")]
    [SerializeField] private Transform stopR;
    [SerializeField] private Transform stopL;
    [SerializeField] private SpwnarObstacle Spwan;
    [SerializeField] private GameManager gameManager;


    private void Update()
    {

        GuardarPontos();


        if (Input.GetMouseButtonDown(0))
        {
            speed = Random.Range(2f, 6f);
            _isRight = !_isRight;
        }
    }
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        if (_isRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            Teleport();
            //if(Vector2.Distance(transform.position, stopR.position) < 0.1f)
            //{
            //    _isRight = !_isRight;
            //}
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            Teleport();
            //if(Vector2.Distance(transform.position, stopL.position) < 0.1f)
            //{
            //    _isRight = !_isRight;
            //}
        }
    }

    private void Teleport()
    {
        if(transform.position.x > 3f)
        {
            transform.position = new Vector2(-3f, transform.position.y);
        }
        else if(transform.position.x < -3f)
        {
            transform.position = new Vector2(3f, transform.position.y);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Obstacle" :
                Destroy(collision.gameObject);
                gameManager.Damage(life--);
                
                if(life < 0)
                {
                    Spwan.ActiveCorrotine = false;
                    Destroy(gameObject);
                    gameManager.Painel();
                }

                break;
            case "Ponts":
                gameManager.Ponts(ponts++);
                Destroy(collision.gameObject);
                break;
        }
    }

    private void GuardarPontos()
    {
        PlayerPrefs.SetInt("pontos", ponts);
    }
}
