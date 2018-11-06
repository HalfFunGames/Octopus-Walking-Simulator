using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Controller : MonoBehaviour {

    public float worldSpeed = 10f;
    public GameObject world;

    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            Walk(false);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            Walk(true);
        }
        else
        {
            gameObject.GetComponent<Animator>().ResetTrigger("Walk");
        }
    }

    private void Walk(bool left)
    {
        if (left)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            transform.localPosition = transform.position = new Vector3(14,0,0);
            world.transform.Rotate(Vector3.forward * worldSpeed);
        }
        else
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            world.transform.Rotate(Vector3.forward * -worldSpeed);

            transform.localPosition = transform.position = new Vector3(0, 0, 0);
        }

        gameObject.GetComponent<Animator>().SetTrigger("Walk");
    }

}
