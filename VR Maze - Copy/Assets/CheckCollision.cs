using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class CheckCollision : MonoBehaviour
{
    int num = 1;
    void Update()
    {
        

    }

    void OnCollisionEnter(Collision col)
    {


        if (col.gameObject.name == "Sphere"|| col.gameObject.name=="Cube")
        {

            if (SceneManager.GetActiveScene().name == "level1")
            {
                SceneManager.LoadScene("level2");
            }
			if (SceneManager.GetActiveScene ().name == "level2") {
				SceneManager.LoadScene ("level3");
			}
			if (SceneManager.GetActiveScene ().name == "level3") {
				SceneManager.LoadScene ("level4");
			}
        }
    }
}


