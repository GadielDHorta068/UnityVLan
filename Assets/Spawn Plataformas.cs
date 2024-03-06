using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SpawnPlataformas : MonoBehaviour
{
    [SerializeField] public GameObject plataforma;
    public float retrasoSpawn = 1.0f;
    private float aux;

    public IEnumerator Spawn()
    {
        yield return new WaitForSeconds(retrasoSpawn);
    }

    void GeneradorPlataformas(float distanciaY)
    {
        GameObject[] plataformas = new GameObject[10] ;
        for(int i = 0; i < plataformas.Length; i++)
        {
            plataformas[i] = plataforma;
            if (i != 0){
                plataformas[i].transform.Translate(plataformas[i-1].transform.position + new Vector3(0,distanciaY,0));
            }    
            Debug.Log(plataformas[i].transform.position);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Spawn());
       GeneradorPlataformas(aux); 
    }
}
