using UnityEngine;
using System.Collections;

public class Obstacles : MonoBehaviour {
    public GameObject[] ob;
    public Transform campos;
	// Use this for initialization
	void Start () {
        ObstacleMaker();
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right*PlayerPrefs.GetInt("speed")*Time.deltaTime);
        GameObject cs = GameObject.Find("Quad1");

	}
    void ObstacleMaker() {
        GameObject clone = (GameObject) Instantiate (ob[Random.Range(0,ob.Length)], transform.position, Quaternion.identity);
        clone.name = "Quad1";
        clone.AddComponent<BoxCollider2D> ();
        clone.GetComponent<BoxCollider2D> ().isTrigger = true;
        float xx = Random.Range(2, 6);
        Invoke("ObstacleMaker", xx);
    }
}
