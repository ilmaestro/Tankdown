using UnityEngine;
using System.Collections;

public class ExplodeMe : MonoBehaviour {
    
    void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name);
        Destroy(gameObject);
    }
}
