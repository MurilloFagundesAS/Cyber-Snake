using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SnakeController : MonoBehaviour
{
    public float velocidade;
    public Rigidbody2D rb;

    public Text txtPontos;
    public int pontos;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(0, 0);
        rb = GetComponent<Rigidbody2D>();

        int x = Random.Range(-1, 1);
        int y = Random.Range(-1, 1);
        rb.velocity = new Vector2(x, y);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0){
            rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal")*velocidade,Input.GetAxisRaw("Vertical")*velocidade);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Moeda")){
            pontos++;
            velocidade += 0.5f;
            if(pontos < 10){
                txtPontos.text = "0" + pontos.ToString();
            }
            else{
                txtPontos.text = pontos.ToString();
            }
            transform.GetChild(0).GetComponent<TrailRenderer>().time++;
            Destroy(other.transform.gameObject);
        }
        if(other.CompareTag("Parede")){
            Destroy(transform.gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }
}
