using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {
    
    //public static float spawnRate;

    private GameObject[] spawnerObj;
    private void Awake()
    {
        if(GameInfomation.scenePlay == "bt_Fruit")
        {
            spawnerObj = Resources.LoadAll<GameObject>("Prefabs/sPlayGame/Fruit");
        }
        else if (GameInfomation.scenePlay == "bt_Alphabet")
        {
            spawnerObj = Resources.LoadAll<GameObject>("Prefabs/sPlayGame/Letters");
        }

    }
    void Update()
    {
        if (GameInfomation.catchStatus == 3)
        {
            spawnCath();
        }
    }
    void spawnCath()
    {
        System.Random randomNum = new System.Random();
        int[] catchRandom = funCatchRandom();
        int randomcatch = randomNum.Next(0,3);
        if (GameInfomation.scenePlay == "bt_Fruit")
        {
            GameInfomation.Spawner = spawnerObj[catchRandom[randomcatch]].GetComponent<BaseFruitClass>().fruitClassName;
        }
        else if (GameInfomation.scenePlay == "bt_Alphabet")
        {
            GameInfomation.Spawner = "Letter_" + spawnerObj[catchRandom[randomcatch]].name;
            Debug.Log("Test: " + GameInfomation.Spawner);
        }
        Vector3 spawnPos1 = transform.position + new Vector3(-1.6f, 0, 0);
        Vector3 spawnPos2 = transform.position + new Vector3(0, 0, 0);
        Vector3 spawnPos3 = transform.position + new Vector3(1.6f, 0, 0);

        int[] instanRandom =new int[3];
        instanRandom[0] = randomNum.Next(0, 3);

        while (instanRandom[1] == instanRandom[0])
        {
            instanRandom[1] = randomNum.Next(0, 3);
        }
        while (instanRandom[2] == instanRandom[0] || instanRandom[2] == instanRandom[1])
        {
            instanRandom[2] = randomNum.Next(0, 3);
        }

        Instantiate(spawnerObj[catchRandom[instanRandom[0]]], spawnPos1, Quaternion.Euler(new Vector3 (180, 0, 0)));
        Instantiate(spawnerObj[catchRandom[instanRandom[1]]], spawnPos2, Quaternion.Euler(new Vector3 (180, 0, 0)));
        Instantiate(spawnerObj[catchRandom[instanRandom[2]]], spawnPos3, Quaternion.Euler(new Vector3 (180, 0, 0)));

        GameInfomation.catchStatus = 0;
    }
    int[] funCatchRandom()
    {
        int[] catchRandom = new int[3];
        System.Random randomNum = new System.Random();

        catchRandom[0] = randomNum.Next(0, spawnerObj.Length); ;
        catchRandom[1] = randomNum.Next(0, spawnerObj.Length); ;
        catchRandom[2] = randomNum.Next(0, spawnerObj.Length); ;
        while (catchRandom[1] == catchRandom[0])
        {
            catchRandom[1] = randomNum.Next(0, spawnerObj.Length);
        }
        while (catchRandom[2] == catchRandom[0] || catchRandom[2] == catchRandom[1])
        {
            catchRandom[2] = randomNum.Next(0, spawnerObj.Length);
        }
        return catchRandom;
    }
}
