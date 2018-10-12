using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ManagerLetters : MonoBehaviour {
    private AudioSource audioSource;
    private Rigidbody rb;
    private AudioClip audioClip;
    private string lettersClassName { get; set; }
    private string lettersClassDescription { get; set; }
    private string mixerName { get; set; }
    private string dirFileSound { get; set; }

    public string LettersClassName
    {
        get { return lettersClassName; }
        set { lettersClassName = value; }
    }
    void createLetters(string className, string classDes, string mixName, string fileSound)
    {
        lettersClassName = className;
        lettersClassDescription = classDes;
        mixerName = mixName;
        dirFileSound = fileSound;
    }
    // Use this for initialization
    private void Awake()
    {
        khoitaoObj();
        audioSource = gameObject.AddComponent<AudioSource>();
        rb = gameObject.AddComponent<Rigidbody>();
        rb.drag = 20;
        AudioMixer audioMixer = Resources.Load<AudioMixer>("Audio/MasterMixer");
        audioSource.outputAudioMixerGroup = audioMixer.FindMatchingGroups(mixerName)[0];
    }
    void Start () {
        if (GameInfomation.scenePlay == "bt_Fruit")
        {
            if (this.gameObject.GetComponent<BaseFruitClass>().fruitClassName == GameInfomation.Spawner)
            StartCoroutine(soundLoad());
        }
        else if (GameInfomation.scenePlay == "bt_Alphabet")
        {
            if (lettersClassName == GameInfomation.Spawner)
                StartCoroutine(soundLoad());
        }        
    }
	
	// Update is called once per frame
	void Update () {
        letterScript();
    }

    IEnumerator soundLoad()
    {
        audioClip = Resources.Load<AudioClip>(dirFileSound);
        audioSource.clip = audioClip;
        audioSource.Play();
        yield return new WaitForSeconds(2);
        audioSource.Play();
    }
    public void Tieuhuy()
    {
        GameInfomation.catchStatus++;
        Destroy(this.gameObject);

    }

    void letterScript()
    {
        transform.Rotate(new Vector3(0, 25, 0) * Time.deltaTime);
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
    void khoitaoObj()
    {
        string nameObject = gameObject.name;
        switch (nameObject)
        {
            case "A(Clone)":
                BaseLetersClass lA = new BaseLetersA();
                createLetters(lA.LettersClassName, lA.LettersClassDescription, lA.MixerName, lA.DirFileSound);
                break;
            case "B(Clone)":
                BaseLetersClass lB = new BaseLetersB();
                createLetters(lB.LettersClassName, lB.LettersClassDescription, lB.MixerName, lB.DirFileSound);
                break;
            case "C(Clone)":
                BaseLetersClass lC = new BaseLetersC();
                createLetters(lC.LettersClassName, lC.LettersClassDescription, lC.MixerName, lC.DirFileSound);
                break;
            case "D(Clone)":
                BaseLetersClass lD = new BaseLetersD();
                createLetters(lD.LettersClassName, lD.LettersClassDescription, lD.MixerName, lD.DirFileSound);
                break;
            case "E(Clone)":
                BaseLetersClass lE = new BaseLetersE();
                createLetters(lE.LettersClassName, lE.LettersClassDescription, lE.MixerName, lE.DirFileSound);
                break;
            case "F(Clone)":
                BaseLetersClass lF = new BaseLetersF();
                createLetters(lF.LettersClassName, lF.LettersClassDescription, lF.MixerName, lF.DirFileSound);
                break;
            case "G(Clone)":
                BaseLetersClass lG = new BaseLetersG();
                createLetters(lG.LettersClassName, lG.LettersClassDescription, lG.MixerName, lG.DirFileSound);
                break;
            case "H(Clone)":
                BaseLetersClass lH = new BaseLetersH();
                createLetters(lH.LettersClassName, lH.LettersClassDescription, lH.MixerName, lH.DirFileSound);
                break;
            case "I(Clone)":
                BaseLetersClass lI = new BaseLetersI();
                createLetters(lI.LettersClassName, lI.LettersClassDescription, lI.MixerName, lI.DirFileSound);
                break;
            case "J(Clone)":
                BaseLetersClass lJ = new BaseLetersJ();
                createLetters(lJ.LettersClassName, lJ.LettersClassDescription, lJ.MixerName, lJ.DirFileSound);
                break;
            case "K(Clone)":
                BaseLetersClass lK = new BaseLetersK();
                createLetters(lK.LettersClassName, lK.LettersClassDescription, lK.MixerName, lK.DirFileSound);
                break;
            case "L(Clone)":
                BaseLetersClass lL = new BaseLetersL();
                createLetters(lL.LettersClassName, lL.LettersClassDescription, lL.MixerName, lL.DirFileSound);
                break;
            case "M(Clone)":
                BaseLetersClass lM = new BaseLetersM();
                createLetters(lM.LettersClassName, lM.LettersClassDescription, lM.MixerName, lM.DirFileSound);
                break;
            case "N(Clone)":
                BaseLetersClass lN = new BaseLetersN();
                createLetters(lN.LettersClassName, lN.LettersClassDescription, lN.MixerName, lN.DirFileSound);
                break;
            case "O(Clone)":
                BaseLetersClass lO = new BaseLetersO();
                createLetters(lO.LettersClassName, lO.LettersClassDescription, lO.MixerName, lO.DirFileSound);
                break;
            case "P(Clone)":
                BaseLetersClass lP = new BaseLetersP();
                createLetters(lP.LettersClassName, lP.LettersClassDescription, lP.MixerName, lP.DirFileSound);
                break;
            case "Q(Clone)":
                BaseLetersClass lQ = new BaseLetersQ();
                createLetters(lQ.LettersClassName, lQ.LettersClassDescription, lQ.MixerName, lQ.DirFileSound);
                break;
            case "R(Clone)":
                BaseLetersClass lR = new BaseLetersR();
                createLetters(lR.LettersClassName, lR.LettersClassDescription, lR.MixerName, lR.DirFileSound);
                break;
            case "S(Clone)":
                BaseLetersClass lS = new BaseLetersS();
                createLetters(lS.LettersClassName, lS.LettersClassDescription, lS.MixerName, lS.DirFileSound);
                break;
            case "T(Clone)":
                BaseLetersClass lT = new BaseLetersT();
                createLetters(lT.LettersClassName, lT.LettersClassDescription, lT.MixerName, lT.DirFileSound);
                break;
            case "U(Clone)":
                BaseLetersClass lU = new BaseLetersU();
                createLetters(lU.LettersClassName, lU.LettersClassDescription, lU.MixerName, lU.DirFileSound);
                break;
            case "V(Clone)":
                BaseLetersClass lV = new BaseLetersV();
                createLetters(lV.LettersClassName, lV.LettersClassDescription, lV.MixerName, lV.DirFileSound);
                break;
            case "W(Clone)":
                BaseLetersClass lW = new BaseLetersW();
                createLetters(lW.LettersClassName, lW.LettersClassDescription, lW.MixerName, lW.DirFileSound);
                break;
            case "X(Clone)":
                BaseLetersClass lX = new BaseLetersX();
                createLetters(lX.LettersClassName, lX.LettersClassDescription, lX.MixerName, lX.DirFileSound);
                break;
            case "Y(Clone)":
                BaseLetersClass lY = new BaseLetersY();
                createLetters(lY.LettersClassName, lY.LettersClassDescription, lY.MixerName, lY.DirFileSound);
                break;
            case "Z(Clone)":
                BaseLetersClass lZ = new BaseLetersZ();
                createLetters(lZ.LettersClassName, lZ.LettersClassDescription, lZ.MixerName, lZ.DirFileSound);
                break;
            default:
                break;
        }
    }
}
