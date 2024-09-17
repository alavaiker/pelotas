using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{

    // La instancia del scriptableObject
    public Spawner spawnManagerValues;



    // Start is called before the first frame update
    void Start()
    {
        SpawnObject();
    }

    void SpawnObject()
    {

        System.Random r = new System.Random();

        for (int i = 0; i < spawnManagerValues.numbrerOfSpawn; i++)
        {
            int a = r.Next(1, 50);
            int b = r.Next(1, 50);
            int c = r.Next(1, 50);
            
            GameObject sphere = spawnManagerValues.sphere;

            int d = r.Next(0, 100);
            int e = r.Next(0, 100);
            int f = r.Next(0, 100);
            
            Color color = new Color(d, e, f);
            MeshRenderer gameObjectRenderer = sphere.GetComponent<MeshRenderer>();
            Material newMaterial = new Material(Shader.Find("Diffuse"));

            newMaterial.color = color;
            gameObjectRenderer.material = newMaterial;

            GameObject currentEntity = Instantiate(spawnManagerValues.sphere, new Vector3(a, b, c), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
