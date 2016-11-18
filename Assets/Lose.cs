using UnityEngine;
using System.Collections;

public class Lose : MonoBehaviour {
    public bool over;
    public GUIStyle style2;
    public Texture image1;
    public AudioSource [] audio;

	// Use this for initialization
	void Start () {
        over = false;
        audio = GetComponents<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.name == "Quad1") {
            Time.timeScale = 0;
            over = true;
            audio[0].Play();
        }
    }

    void OnGUI() {
        if (over)
        {
            GUI.Label(new Rect(Screen.width * 0.3f, Screen.height * 0.4f, Screen.width * 0.75f, Screen.height * 0.25f),"GAME OVER !", style2);
            if(GUI.Button(new Rect(Screen.width * 0.48f, Screen.height * 0.55f,50,50), image1)){
                Application.LoadLevel("Scene1");
               
                Time.timeScale = 1;
            }
         }
    }
}
