using UnityEngine;

public class Detectollision : MonoBehaviour
{
    int hits;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hits > 10) Destroy(gameObject);

    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Player").GetComponent<PlayerController>().score++;
        Debug.Log(GameObject.Find("Player").GetComponent<PlayerController>().score);
        float sizeChange = transform.localScale.x * 0.1f;
        transform.localScale -= new Vector3(sizeChange, sizeChange, sizeChange);
        hits++;
        transform.rotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
        
        

    }
}
