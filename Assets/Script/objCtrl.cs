using UnityEngine;
using System.Collections;

public class objCtrl : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "BULLET")
        {
            Destroy(other.gameObject);
        }
    }
}
