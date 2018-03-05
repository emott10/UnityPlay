using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

    public GameObject laserPrefab;
    public float fireRate = 8f;
    float fireTimer;


    [SerializeField]
    private float speed = 10.0f;
    

   

	// Use this for initialization
	void Start ()
    {
        transform.position = new Vector3(0, 0, 0);
        fireTimer = Time.time;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Movement();

        if (Input.touchCount > 0)
        {
            if (Time.time >= 1 / fireRate + fireTimer)
            {
                fireTimer = Time.time;
                Instantiate(laserPrefab, transform.position + new Vector3(0, 0.88f, 0), Quaternion.identity);
            }
        }
    }

    private void Movement()
    {
        float horizontalInput = CrossPlatformInputManager.GetAxis("Horizontal");
        float verticalInput = CrossPlatformInputManager.GetAxis("Vertical");
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.up * speed * verticalInput * Time.deltaTime);

        if (transform.position.y > 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }

        else if (transform.position.y < -4.35)
        {
            transform.position = new Vector3(transform.position.x, -4.35f, 0);
        }

        if (transform.position.x < -8.95)
        {
            transform.position = new Vector3(9, transform.position.y, 0);
        }

        else if (transform.position.x > 9)
        {
            transform.position = new Vector3(-8.95f, transform.position.y, 0);
        }
    }
}
