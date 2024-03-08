using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    [SerializeField] GameObject player;
    private bool endGame = false;

    
    void Start()
    {
        StartCoroutine(ActualizarPerder());
    }
    void Update()
    {
       
        if (!endGame && player!=null){
            transform.DOMoveY(player.transform.position.y+3, 0.8f);
            //transform.position = new Vector3(0, player.transform.position.y ,-10);
        }
    }

    public IEnumerator ActualizarPerder()
    {
        float aux= player.transform.position.y;
        yield return new WaitForSeconds(0.2f);
        if (aux > player.transform.position.y) 
        {
            Debug.Log(aux- player.transform.position.y);
            endGame = true;
            if (player == null)
            {
                Debug.Log("Perder, dejar de trackear jugador, stop puntaje, spawn, crear evento y bool");
            }     
        }else{ endGame=false;}
        StartCoroutine(ActualizarPerder());
    }
}
