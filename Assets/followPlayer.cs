using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    [SerializeField] GameObject player;
    void Update()
    {
        //transform.position = new Vector3(0, player.transform.position.y ,-10);
        transform.DOMoveY(player.transform.position.y+3, 0.8f);
    }
}
