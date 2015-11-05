using UnityEngine;
using System.Collections;

public class goalCtrl : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "GOAL")
        {

            Application.LoadLevel("sc");
        }
    }

    void OnGUI(Collision2D other)
    {
        if (other.collider.tag == "GOAL")
        {
            GUI.Label(new Rect(Screen.width / 2, 80, 1000, 20), "YEAH!");
        }
    }
}
