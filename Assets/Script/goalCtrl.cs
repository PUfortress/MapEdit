using UnityEngine;
using System.Collections;

public class goalCtrl : MonoBehaviour
{

    private bool is_collided = false;
    public float GOAL_MIN = 6.0f;
    public float GOAL_MAX = 10.0f;

    // Use this for initialization
    void Start()
    {
        float rnd = Random.Range(GOAL_MIN, GOAL_MAX);
        this.transform.position = new Vector3(rnd, 0.0f, 0.0f);

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionStay(Collision other)
    {
        this.is_collided = true;
    }

    void DeletePolygon()
    {
        if(is_collided)
        {
            DestroyImmediate(transform.gameObject);
        }
    }


    void OnGUI()
    {
        if (is_collided)
        {
            GUI.Label(new Rect(Screen.width / 2, 80, 1000, 20), "YEAH!");
        }
    }

}
