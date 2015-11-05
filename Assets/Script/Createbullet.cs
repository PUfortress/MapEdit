using UnityEngine;
using System.Collections;

public class Createbullet : MonoBehaviour {

    public GameObject bullet;
    public Transform firepos;
    public RigidbodyConstraints constraints;

    // Update is called once per frame
    void Update () {
	    if (Input.GetMouseButtonDown(0))
        {
            fire();
        }
	}

    void fire()
    {
        createbullet();
    }

    void createbullet()
    {
        Instantiate(bullet, firepos.position, firepos.rotation);
    }
}
