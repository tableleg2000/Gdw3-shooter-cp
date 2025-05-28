using UnityEngine;
using TMPro;



public class PlayerController : MonoBehaviour
{
   
    public float speed  = 8f;
    public float xRange = 20;
    public float yRange = 20;
    public GameObject projectilePrefab;
    public Vector3 spawnOffset;
    public int score;
    public TMP_Text scoreText;
    public float power;
    public Transform spawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        float verticalInput = Input.GetAxisRaw("Vertical");

        scoreText.text = "score: " + score;

        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;




        transform.Translate(moveDirection * speed * Time.deltaTime);

        //Shooting Mechanic
        //Away to 

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from the player
            Destroy(Instantiate(projectilePrefab, spawnPoint.position, transform.rotation),20);
        }
            


        //Keep the player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
     
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3( xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -yRange)
        {
            transform.position = new Vector3( transform.position.x, transform.position.y, -yRange);
        }
        if (transform.position.z > yRange)
        {
            transform.position = new Vector3( transform.position.x, transform.position.y, yRange);
        }
    }

    
}
