using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallControl : MonoBehaviour
{

  public static int now = 1;
  int idx = 2;
  int panel = 0;
  public GameObject childPrefab;
  Transform parent;
  // public GameObject txt;
  public GameObject gmov;
  bool playing=true;
    // Start is called before the first frame update
    void Start()
    {
      parent = this.transform;
      for(int i = 0;i<150;i++){
        GameObject obj = Instantiate(childPrefab,
                    new Vector3(parent.position.x+Random.Range(-3,3),parent.position.y,parent.position.z+Random.Range(0,-8.5f)),
                    Quaternion.identity, parent);
        obj.SetActive(false);
      }

    }

    // Update is called once per frame
    void Update()
    {
      if(playing){
        Vector3 pos = this.transform.position;
        pos.z += 0.5f;
        if(Input.GetKey(KeyCode.LeftArrow)
            && pos.x > -3){
          pos.x -=0.8f;
        }
        if(Input.GetKey(KeyCode.RightArrow)
            && pos.x < 3){
          pos.x +=0.8f;
        }
        this.transform.position = pos;
      }


    }

    void OnTriggerEnter(Collider obj){
      if(obj.gameObject.tag == "Finish"){
        playing=false;
        SceneManager.LoadScene("Boss");
      }

      panel = 0;
      Debug.Log(obj);
      if(obj.gameObject.tag == "p5"){
        panel = 5;
      }
      if(obj.gameObject.tag == "p4"){
        panel = 4;
      }
      if(obj.gameObject.tag == "p3"){
        panel = 3;
      }
      if(obj.gameObject.tag == "p2"){
        panel = 2;
      }
      if(obj.gameObject.tag == "p1"){
        panel = 1;
      }
      if(obj.gameObject.tag == "p15"){
        panel = 15;
      }
      if(obj.gameObject.tag == "13"){
        panel = 13;
      }
      if(obj.gameObject.tag == "p82"){
        panel = 82;
      }
      if(obj.gameObject.tag == "p20"){
        panel = 20;
      }
      if(obj.gameObject.tag == "m5"){
        panel = -5;
      }
      if(obj.gameObject.tag == "m15"){
        panel = -15;
      }
      if(obj.gameObject.tag == "t5"){
        panel = now*4;
      }
      if(obj.gameObject.tag == "m2"){
        panel = -2;
      }
      if(obj.gameObject.tag == "d3"){
        panel =  Mathf.FloorToInt(-now/3)*2;
      }
      if(obj.gameObject.tag == "d5"){
        panel =  Mathf.FloorToInt(-now/5)*4;
      }
      if(obj.gameObject.tag == "t3"){
        panel = now*2;
      }
      if(obj.gameObject.tag == "d150"){
        panel = -150;
      }

      Debug.Log(panel);

      if(panel > 0){
        for(int i = idx;i<idx+panel;i++){
          now++;
          parent.GetChild(i).gameObject.SetActive(true);
        }
        idx += panel;
      }else{
        // Debug.Log(now+" "+panel);
        if(now + panel <= 0){
          // gameover
          Debug.Log("gameover");
          playing = false;
          gmov.SetActive(true);

        }else{
          for(int i = idx;i>idx+panel;i--){
            now--;
            parent.GetChild(i).gameObject.SetActive(false);
          }
          idx += panel;
        }

      }
      // txt.GetComponent<Text>().text = now.ToString();

    }
}
