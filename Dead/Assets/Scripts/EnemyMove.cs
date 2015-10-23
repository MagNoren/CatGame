using UnityEngine;
using System.Collections;
using System.Threading;

public class EnemyMove : MonoBehaviour {

    public float enemySpeed = 2;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        System.Threading.Thread.Sleep(10);
        transform.Translate(Vector2.right * enemySpeed * Time.deltaTime);
        System.Threading.Thread.Sleep(10);
        transform.Translate(Vector2.left * enemySpeed * Time.deltaTime);
        
    }
}
