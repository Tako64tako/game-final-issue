using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufo : MonoBehaviour
{
  Vector3 pos;
  public float a;
  public float b;
  public float c;
  public float d;
    // Start is called before the first frame update
    void Start()
    {
      pos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(pos.x+Mathf.PingPong(Time.time/a, b),pos.y+Mathf.PingPong(Time.time/c, d), pos.z);
    }
}
