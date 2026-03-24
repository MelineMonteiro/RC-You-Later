using UnityEngine;

public class FOVManager : MonoBehaviour
{

    public Rigidbody rb;
    public RemoteControlCarController carController;
    public Speedometer Speedometer;
    public Camera mainCamera;
    public float carMagnitude;

    public float minFOV = 60f;
    public float maxFOV = 120f;
    
    private float maxAcceleration = 5f;

    

    public Vector3 velocity;


    
    void Start()
    {
        mainCamera.fieldOfView = minFOV;
    }

    
    void LateUpdate()
    {
    //    Vector3 velocity = carController.Velocity;

    //    float currentSpeed = Speedometer.bufferDistance / Speedometer.bufferTime;

    ////carMagnitude = Vector3.Magnitude(velocity);
    //float speed = Speedometer;

    //    float valeur = Mathf.Clamp01 (speed / maxAcceleration);

    //    float forwardDot = Vector3.Dot(velocity.normalized, carController.transform.forward);


    //    if (forwardDot > 0.1f)
    //    {
    //        mainCamera.fieldOfView = Mathf.Lerp(mainCamera.fieldOfView, Mathf.Lerp(minFOV, maxFOV, valeur), Time.deltaTime * 5f);
    //    }
    //    else
    //    {
    //        mainCamera.fieldOfView = Mathf.Lerp(mainCamera.fieldOfView, minFOV, Time.deltaTime * 5f);
    //    }

    }
}
