using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        Instantiate(plataforma);
        
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
