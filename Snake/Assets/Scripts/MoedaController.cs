using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoedaController : MonoBehaviour
{
    public float tempo;
    public float tempoVida;
    // Update is called once per frame
    void Update()
    {
        tempo += Time.deltaTime;
        if(tempo >= tempoVida){
            Destroy(transform.gameObject);
        }
    }
}
