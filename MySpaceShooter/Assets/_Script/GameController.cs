using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject hazards;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait = 1.0f;
    public float waveWait = 2;



    private Vector3 spawnPosition = Vector3.zero;
    private Quaternion spawnRotation;

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);

        while(true)
        {
            for (int i = 0; i < hazardCount; ++i)
            {
                spawnPosition.x = Random.Range(-spawnValues.x, spawnValues.x);
                spawnPosition.z = spawnValues.z;
                spawnRotation = Quaternion.identity;
                Instantiate(hazards, spawnPosition, spawnRotation);

                yield return new WaitForSeconds
                (spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }


	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnWaves());
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
