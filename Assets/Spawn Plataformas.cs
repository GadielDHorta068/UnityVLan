using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;

public class SpawnPlataformas : MonoBehaviour
{
    [SerializeField] public GameObject plataforma;
    public float retrasoSpawn = 1.0f;
    public int distanciaEntrePlataformas;
    private float aux;

    public IEnumerator Spawn()
    {
        yield return new WaitForSeconds(retrasoSpawn);
    }

    void GeneradorPlataformas(float distanciaY)
    {
        float Ancho = Random.Range(-4, 4);//Random.Range(-Screen.width/2, Screen.width/2);
        plataforma.transform.position = new Vector3(0,0,0);
        GameObject[] plataformas = new GameObject[10] ;
        for(int i = 0; i < plataformas.Length; i++)
        {
            plataformas[i] = plataforma;
            
            if (i != 0){
                plataformas[i].transform.position = plataformas[i-1].transform.position + new Vector3(Ancho,distanciaY,0);
            }
            Debug.Log(plataformas[i].transform.position);
            Instantiate(plataformas[i]);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Spawn());
       GeneradorPlataformas(distanciaEntrePlataformas); 
    }
}
