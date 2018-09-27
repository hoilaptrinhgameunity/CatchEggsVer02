using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseFruitClass : MonoBehaviour {
    public string fruitClassName;
    public string fruitClassDescription;
    
    private AudioSource audioSource;
    // Use this for initialization
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        if (this.gameObject.GetComponent<BaseFruitClass>().fruitClassName == GameInfomation.Spawner)
            StartCoroutine(soundLoad());
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(-15, 2, 2) * Time.deltaTime);
        float fallSpeed = Time.deltaTime;
        if (GameInfomation.gameStatus == (int)GameInfomation.statusGame.batdau)
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            transform.position -= new Vector3(0, fallSpeed, 0);

        }
        if (GameInfomation.gameStatus == (int)GameInfomation.statusGame.ketthuc)
        {
            Tieuhuy();
        }
        if (transform.position.y < -1 || transform.position.y >= 20)
        {
            //Destroy this gameobject (and all attached components)
            GameInfomation.catchStatus++;
            Destroy(this.gameObject);
            /*if (transform.gameObject.name == "Egg")
            {
                GameMNG.health -= 1f;
            }*/
        }
    }
    public void Tieuhuy()
    {
        GameInfomation.catchStatus++;
        Destroy(this.gameObject);
        
    }
    IEnumerator soundLoad()
    {
        audioSource.Play();
        yield return new WaitForSeconds(2);
        audioSource.Play();
    }
}
