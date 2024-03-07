using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Plataforma : MonoBehaviour
{
    Collider2D col;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
        //col.enabled = false;
    }

    public void ColliderOnEnable()
    {
        col.enabled = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        col.isTrigger = false;
        col.enabled = true;
        StartCoroutine(destruir());
    }

    public IEnumerator destruir()
    {
        float tiempo = 2.0f;
        GetComponent<SpriteRenderer>().DOFade(0,tiempo);
        yield return new WaitForSeconds(tiempo);
        Destroy(gameObject);
    }
}
