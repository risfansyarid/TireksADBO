using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour
{
    public float jumpHeight = 5;
    public bool isFalling = false;
    public float jumpForce = 1000f;
    public AudioSource[] audioLain;

    void Start()
    {
        PlayerPrefs.SetInt("speed", 7);
        audioLain = GetComponents<AudioSource>();
    }


    void Update()
    {

        transform.Translate(Vector3.right * PlayerPrefs.GetInt("speed") * Time.deltaTime);
        if (Input.GetKey(KeyCode.Space) && isFalling == false)
        {

            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));
            isFalling = true;
            audioLain[1].Play();
        }




    }
    void OnCollisionStay2D(Collision2D coll)
    {

        isFalling = false;

    }
}
