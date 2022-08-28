using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject TargetP;
    public GameObject TargetV;
    public GameObject TargetS;

    public GameObject sctxt;
    public GameObject cltxt;
    public static int sc;


    private bool playing = true;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i< 10; i++){
          GameObject Target = Instantiate(TargetP);
          Target.transform.position = new Vector3(Random.Range(20f,-20f),15f,Random.Range(40f,0f));
        }
        for (int i = 0; i< 3; i++){
          GameObject Target = Instantiate(TargetV);
          Target.transform.position = new Vector3(Random.Range(-30f,30f),10f,Random.Range(30f,-10f));
        }
        for (int i = 0; i< 1; i++){
          GameObject Target = Instantiate(TargetS);
          Target.transform.position = new Vector3(Random.Range(30f,-30f),18f,Random.Range(30f,-10f));
        }

    }

    // Update is called once per frame
    void Update()
    {
      sctxt.GetComponent<Text>().text = "point:"+sc.ToString();
      if(sc == 29){
        cltxt.SetActive(true);
        playing = false;
      }
      if(HodaiControll.ball == 0){
        cltxt.SetActive(true);
        cltxt.GetComponent<Text>().text = "GAMEOVER";
        playing = false;
      }


    }
}
