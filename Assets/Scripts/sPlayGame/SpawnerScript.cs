using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {
    
    //public static float spawnRate;

    private GameObject[] spawnerObj;
    void Start()
    {
        spawnerObj = Resources.LoadAll<GameObject>("Prefabs/sPlayGame/Fruit");
    }
    void Update()
    {
        if (GameInfomation.catchStatus == (int)GameInfomation.statusGame.batdau)
        {            
            spawnCath();
        }
    }
    void spawnCath()
    {
        int[] catchRandom = funCatchRandom();
        GameInfomation.Spawner = spawnerObj[catchRandom[0]].GetComponent<BaseFruitClass>().fruitClassName;
        
        Vector3 spawnPos1 = transform.position + new Vector3(-1.6f, 0, 0);
        Vector3 spawnPos2 = transform.position + new Vector3(0, 0, 0);
        Vector3 spawnPos3 = transform.position + new Vector3(1.6f, 0, 0);

        int[] instanRandom =new int[3];
        instanRandom[0] = Random.Range(0, 3);

        while (instanRandom[1] == instanRandom[0])
        {
            instanRandom[1] = Random.Range(0, 3);
        }
        while (instanRandom[2] == instanRandom[0] || instanRandom[2] == instanRandom[1])
        {
            instanRandom[2] = Random.Range(0, 3);
        }
        
        Instantiate(spawnerObj[catchRandom[instanRandom[0]]], spawnPos1, spawnerObj[catchRandom[instanRandom[0]]].transform.rotation);
        Instantiate(spawnerObj[catchRandom[instanRandom[1]]], spawnPos2, spawnerObj[catchRandom[instanRandom[1]]].transform.rotation);
        Instantiate(spawnerObj[catchRandom[instanRandom[2]]], spawnPos3, spawnerObj[catchRandom[instanRandom[2]]].transform.rotation);
        GameInfomation.catchStatus = (int)GameInfomation.statusGame.tamdung;
        //Debug.Log(GameInfomation.Spawner);
    }
    int[] funCatchRandom()
    {
        int[] catchRandom = new int[3];
        catchRandom[0] = Random.Range(0, spawnerObj.Length); ;
        catchRandom[1] = Random.Range(0, spawnerObj.Length); ;
        catchRandom[2] = Random.Range(0, spawnerObj.Length); ;
        while (catchRandom[1] == catchRandom[0])
        {
            catchRandom[1] = Random.Range(0, spawnerObj.Length);
        }
        while (catchRandom[2] == catchRandom[0] || catchRandom[2] == catchRandom[1])
        {
            catchRandom[2] = Random.Range(0, spawnerObj.Length);
        }
        return catchRandom;
    }

}
