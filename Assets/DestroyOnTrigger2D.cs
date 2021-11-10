using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    [SerializeField] int live;
    AudioSource audioData;

    private void OnTriggerEnter2D(Collider2D other) {
        audioData = GetComponent<AudioSource>();
        if (other.tag == triggeringTag && enabled && live == 1) {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        //audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        }
        else if(other.tag == triggeringTag && enabled){ 
            Destroy(other.gameObject);
            live--;
        //audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        }
        
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
        if( transform.position.y<-3f){
            Destroy(this.gameObject);
        }
    }
}
