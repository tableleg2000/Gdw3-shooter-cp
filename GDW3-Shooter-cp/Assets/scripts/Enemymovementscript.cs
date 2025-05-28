using UnityEngine;

public class Enemymovementscript : MonoBehaviour

{
   
    public float speed = 40.0f;
    private Vector3 _movementDirection;
    private Vector3 reflectedDirection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    
   
    private void OnBeforeTransformParentChanged()
    {
        transform.Translate(_movementDirection * speed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision collision)
    {
        //Get the collision normal (direction of the wall surface)
        Vector3 collisionNormal = collision.contacts[0].normal;

        // calculate the relected direction
        Vector3 relectedDirection = Vector3.Reflect(_movementDirection, collisionNormal);

        //Change the enemy's movement direction
        _movementDirection = reflectedDirection;
    }
}
