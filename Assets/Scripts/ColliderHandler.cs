using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderHandler : MonoBehaviour
{
    public string targerTag;
    private void OnCollisionEnter(Collision other) {
        if(other.collider.tag == targerTag){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    
}
