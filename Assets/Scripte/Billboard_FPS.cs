using UnityEngine;
using System.Collections;

public class Billboard_FPS : MonoBehaviour {

	void Update ()
    {

        transform.LookAt(GetComponent<Camera>().transform);

    }
}
