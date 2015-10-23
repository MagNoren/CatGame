using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

    public string nextLevel;
    private bool endLevel = false;

    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update ()
    {
        if (endLevel)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Application.LoadLevel(nextLevel);
            }
        }
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            endLevel = true;
        }
    }


}
