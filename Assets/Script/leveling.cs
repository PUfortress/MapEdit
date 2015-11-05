using UnityEngine;
using System.Collections;

public class leveling : MonoBehaviour
{

    private bool is_collided = false;
    public float GOAL_XMIN = 110.0f;
    public float GOAL_XMAX = 147.9f;
    public float GOAL_YMIN = 7.4f;
    public float GOAL_YMAX = 53.0f;

    // Use this for initialization
    void Start()
    {
        float xrnd = Random.Range(GOAL_XMIN, GOAL_XMAX);
        float yrnd = Random.Range(GOAL_YMIN, GOAL_YMAX);
        this.transform.position = new Vector3(xrnd, yrnd, 0.0f);

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionStay(Collision other)
    {
        this.is_collided = true;
    }


    void OnGUI()
    {
        if (is_collided)
        {
            GUI.Label(new Rect(Screen.width / 2, 80, 1000, 20), "YEAH!");
        }
    }

}
