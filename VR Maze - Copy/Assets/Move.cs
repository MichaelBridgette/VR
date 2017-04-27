using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    public float speed;

    void Update()
    {
        // GetAxisRaw is unsmoothed input -1, 0, 1
        float v = Input.GetAxisRaw("Vertical");
        float h = Input.GetAxisRaw("Horizontal");

        // normalize so going diagonally doesn't speed things up
        Vector3 direction = new Vector3(h, 0, v).normalized;

        // translate
        transform.Translate(direction * speed * Time.deltaTime);
    }
}

