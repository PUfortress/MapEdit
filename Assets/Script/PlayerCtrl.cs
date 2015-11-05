using UnityEngine;
using System.Collections;



public class PlayerCtrl : MonoBehaviour
{
    private float power;
    public float POWERPLUS = 1200.0f;
    public GameObject bullet;
    public Transform firepos;
    public RigidbodyConstraints2D rigidbodyconstraints2d;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
            power += POWERPLUS * Time.deltaTime;
        }
        if (Input.GetMouseButtonUp(0))
        {
            this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            this.GetComponent<Rigidbody2D>().AddForce(new Vector3(power, power, 0));
            power = 0.0f;
        }
    }

    void fire()
    {
        createbullet();
    }

    void createbullet()
    {
        Instantiate(bullet, firepos.position, firepos.rotation);
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
    }
}