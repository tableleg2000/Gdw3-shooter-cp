using UnityEngine;

public class MoveForward : MonoBehaviour
{

    public Vector3 direction;
    //public float speed = 30;
    public float speed = 30f;
    public float forceModifier = 0.5f; // Amount to increase velocity per second
    public string shootButton = "Space"; //Name of Button To use
    private Rigidbody projectileRigidbody;
    private float elapsedTime;
    public GameObject player;

  
   
    void start() 
    {
        projectileRigidbody = GetComponent<Rigidbody>();
        if (projectileRigidbody == null)
        {
            Debug.LogError("No Rigidbody found on this GameObject");
        }

         Rigidbody playerRb = player.GetComponent<Rigidbody>();
    }

    private void Start()
    {
        GetComponent <Rigidbody>().AddRelativeForce(direction * speed, ForceMode.Impulse);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(shootButton))
        {
            elapsedTime = 0;
        }
        if (Input.GetButton(shootButton))
        {
            elapsedTime += Time.deltaTime;
            float currentVelocity = speed + elapsedTime * forceModifier;
            projectileRigidbody.AddForce(transform.forward * currentVelocity, ForceMode.VelocityChange);
        }
       
    }
}
