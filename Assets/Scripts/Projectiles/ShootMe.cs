using UnityEngine;
using System.Collections;

public class ShootMe : MonoBehaviour {

    public void Fire(float speed)
    {
        rigidbody.AddForce(transform.forward * speed);
    }
}
