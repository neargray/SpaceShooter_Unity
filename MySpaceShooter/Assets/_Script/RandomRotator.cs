using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {

    public float tumble = 20.0f;

    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
    }


}
