using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorRandomController : MonoBehaviour
{
    public float tempoMinimo;
    public float tempo;

    public float xMin;
    public float xMax;

    public float yMin;
    public float yMax;

    public GameObject moeda;
    // Start is called before the first frame update
    void Start()
    {
        tempo = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        tempo += Time.deltaTime;
        if(tempo >= tempoMinimo){
            float x = Random.Range(xMin, xMax);
            float y = Random.Range(yMin, yMax);
            Instantiate(moeda, new Vector2(x, y), Quaternion.identity);
            tempo = 0;
        }
    }
}
