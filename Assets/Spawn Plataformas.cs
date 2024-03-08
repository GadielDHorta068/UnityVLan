using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Unity.VisualScripting;

public class SpawnPlataformas : MonoBehaviour
{
    [SerializeField] public GameObject plataforma;
    public float retrasoSpawn = 1.0f;
    public int distanciaEntrePlataformas;
    private float aux;

    public IEnumerator Spawn()
    {
        //Proximamente
        yield return new WaitForSeconds(retrasoSpawn);
    }

    void GeneradorPlataformas(float distanciaY)
    {
        //Set posicion origen de plataforma
        plataforma.transform.position = new Vector3(0,0,0);

        //Crear 10 plataformas de prueba
        GameObject[] plataformas = new GameObject[10] ;
        for(int i = 0; i < plataformas.Length; i++)
        {
            //Ancho decide el X donde spawn X la plataforma, renombrar variable a mas apropiada
            float Ancho = Random.Range(-4.0f, 4.0f);//Random.Range(-Screen.width/2, Screen.width/2);
            
            plataformas[i] = plataforma;

            //Variar el y entre plataformas
            distanciaY = distanciaEntrePlataformas + Random.Range(-1.0f, 3.0f);
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
