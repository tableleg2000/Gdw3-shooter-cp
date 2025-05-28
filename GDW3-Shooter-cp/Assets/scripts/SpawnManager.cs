using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animal;
    private float spawnRangeX = 50;
    private float spawnPosZ = 50;
    public animalInfo[] animalInfomation;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    //public string[] names;
    // Start is called once before the first execution of Update after the MonoBehaviour is create


    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   void SpawnRandomAnimal()
   { 
      //Randomly generate animal index and spawn position
      Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(-spawnPosZ, spawnPosZ));
      int animalIndex = Random.Range(0, animal.Length);
      Instantiate(animal[animalIndex], spawnPos, Quaternion.Euler(0, Random.Range(0, 360), 0));
    
   }
}


public struct animalInfo
{
    public GameObject animal;
    public string animalName;
    public bool isHostile;

}

 