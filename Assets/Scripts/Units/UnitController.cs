using UnityEngine;
using System.Collections;

public class UnitController : MonoBehaviour {

    /// <summary>
    /// Handle speed increase/decrease and turning right/left
    /// </summary>

    public float maxSpeed = 20f;
    public float acceleration = 2f;
    public float damping = 0.9f;

    private float currentSpeed = 0f;

    void Awake() 
    { 

    }

	void Start () 
    {
        currentSpeed = 0f;
	}
	
	void Update () 
    {
        CheckPosition();
        CheckRotation();
	}

    void CheckRotation()
    {
        Vector3 targetRotation = new Vector3(0, Input.GetAxis("Horizontal") * acceleration, 0) + transform.rotation.eulerAngles;
        transform.rotation =  Quaternion.Euler(targetRotation);
        
    }

    void CheckPosition()
    {
        //check for speed adjustments
        if (currentSpeed >= -maxSpeed && currentSpeed <= maxSpeed)
            currentSpeed += Input.GetAxis("Vertical") * acceleration;

        //move based on speed
        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
        currentSpeed *= damping;
    }
}
