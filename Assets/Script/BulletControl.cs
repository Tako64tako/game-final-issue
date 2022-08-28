using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletControl : MonoBehaviour
{
  public AudioClip sound1;
  AudioSource audioSource;
  float countTime = 0;
   public GameObject particleObject;
    // Start is called before the first frame update
    void Start()
    {
      audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
      countTime += Time.deltaTime;
      if(countTime >= 3){
        Destroy(this.gameObject);
      }
    }

    private void OnCollisionEnter(Collision collision){
      if (collision.gameObject.CompareTag("Target")){
        audioSource.PlayOneShot(sound1);
        Destroy(collision.gameObject);
        Destroy(this.gameObject);
         Instantiate(particleObject, this.transform.position, Quaternion.identity);
         GameManager.sc+=1;

      }
        if (collision.gameObject.CompareTag("silver")){
          audioSource.PlayOneShot(sound1);
          Destroy(collision.gameObject);
          Destroy(this.gameObject);
           Instantiate(particleObject, this.transform.position, Quaternion.identity);
          GameManager.sc+=3;
        }
        if (collision.gameObject.CompareTag("gold")){
          audioSource.PlayOneShot(sound1);
          Destroy(collision.gameObject);
          Destroy(this.gameObject);

           Instantiate(particleObject, this.transform.position, Quaternion.identity);
          GameManager.sc+=11;
        }

    }

}
