using UnityEngine;
using System.Collections;

public class UnitController : MonoBehaviour {

    /// <summary>
    /// Handle speed increase/decrease and turning right/left
    /// </summary>

    public float maxSpeed = 20f;
    public float acceleration = 2f;
    public float damping = 0.9f;
    public GameObject projectile;
    public Transform firePoint;
    public float fireForce = 50f;
    public float fireRate = 1f;

    private float currentSpeed = 0f;
    private float lastFireTime = 0f;
    void Awake() 
    { 

    }

	void Start () 
    {
        currentSpeed = 0f;
        lastFireTime = Time.time;
	}
	
	void Update () 
    {
        CheckPosition();
        CheckRotation();
        CheckFire();
	}

    private void CheckFire()
    {
        if (Input.GetButton("Fire1") && Time.time >= lastFireTime)
        {
            GameObject proj = (GameObject)Instantiate(projectile, firePoint.position, firePoint.rotation);
            proj.GetComponent<ShootMe>().Fire(fireForce);
            //proj.rigidbody.AddForce(firePoint.position.normalized * fireForce);

            lastFireTime = Time.time + fireRate;
        }

    }

    private void CheckRotation()
    {
        Vector3 targetRotation = new Vector3(0, Input.GetAxis("Horizontal") * acceleration, 0) + transform.rotation.eulerAngles;
        transform.rotation =  Quaternion.Euler(targetRotation);
        
    }

    private void CheckPosition()
    {
        //check for speed adjustments
        if (currentSpeed >= -maxSpeed && currentSpeed <= maxSpeed)
            currentSpeed += Input.GetAxis("Vertical") * acceleration;

        //move based on speed
        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
        currentSpeed *= damping;
    }
}
