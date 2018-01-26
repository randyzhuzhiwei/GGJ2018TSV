using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateAsteriods : MonoBehaviour {

    private Vector3 origin = Vector3.zero;
    public GameObject asteroid;
    public GameObject[] asteroids;

    public float minSize = 0.01f;
    public float maxSize = 0.1f;

    public float minCount = 20f;
    public float maxCount = 45f;

    public float minDist = 300f;
    public float maxDist = 1500f;


    // Use this for initialization
    void Start () {
        origin = transform.position;
        int count = (int)Random.Range(minCount, maxCount);
        Debug.Log(count);
        asteroids = new GameObject[count];
        GenerateAsteroids(count);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GenerateAsteroids(int count)
    {
        for (int i = 0; i < count; i++)
        {
            int size = (int) Random.Range(minSize, maxSize);
            float size2 = (float) size / 100;

            Debug.Log(size2);
            GameObject prefab = asteroid;
            Vector3 pos= origin;

            for (int j = 0; j < 100; j++)
            {
                pos = Random.insideUnitSphere * (minDist + (maxDist - minDist) * Random.value);
                pos += origin;
                if (Physics.CheckSphere(pos, size2*2))
                {
                    break;
                }
            }
            asteroids[i]= Instantiate(prefab, pos, Quaternion.identity);
            asteroids[i].GetComponent<BoxCollider2D>().size=new Vector2(size2, size2);
            asteroids[i].transform.localScale = new Vector3(size2, size2, size2);

           
        }
    }
}
