using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HodaiControll : MonoBehaviour
{
    Vector3 p;
    Vector3 rY = new Vector3(0f,1f,0f);
    public GameObject BulletP;
    public static int ball;

    public GameObject txt;
    // Start is called before the first frame update
    void Start()
    {
      p = transform.position-transform.up * transform.localScale.y;
      ball = BallControl.now;
      //Debug
      ball = 100;
      txt.GetComponent<Text>().text = ball.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)){
          transform.RotateAround(p,transform.right,1f);
        }
        if (Input.GetKey(KeyCode.DownArrow)){
          transform.RotateAround(p,transform.right,-1f);
        }
        if (Input.GetKey(KeyCode.RightArrow)){
          transform.RotateAround(p,rY,1f);
        }
        if (Input.GetKey(KeyCode.LeftArrow)){
          transform.RotateAround(p,rY,-1f);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
          if(ball > 0){
            ball--;
            GameObject Bullet = Instantiate(BulletP);
            Bullet.transform.position  = transform.position + transform.up * transform.lossyScale.y * 1.1f;
            Bullet.GetComponent<Rigidbody>().AddForce(transform.up * 1500f);
            txt.GetComponent<Text>().text = "あと"+ball.ToString();
          }

        }
    }
}
