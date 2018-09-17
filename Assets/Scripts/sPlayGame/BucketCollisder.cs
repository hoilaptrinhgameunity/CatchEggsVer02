using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketCollisder : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<BaseFruitClass>().fruitClassName == GameInfomation.Spawner)
        {
            Debug.Log("Chuc mung: Diem + 1");
            Destroy(other.gameObject);
            GameInfomation.catchStatus++;
        }
        else
        {
            Debug.Log("Chia buon: Diem - 1");
            Destroy(other.gameObject);
            GameInfomation.catchStatus++;
        }
    }
}
