using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    float vel = 30f;
    public bool is_on_ground = false;
    public int current_health = 100;
    public GameObject gameoverui;
    public bool is_active = true;
    public bool is_caught = false;
    float original;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        original = transform.localScale.y;
        
    }

    // Update is called once per frame
    void Update()
    {
      


        float Horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * vel;
        float Vertical = Input.GetAxis("Vertical") * Time.deltaTime * vel;
        transform.Translate(Horizontal, 0, Vertical);

        if (is_active)
        {
            if (Input.GetKeyDown("space") && is_on_ground)
            {
                rb.AddForce(new Vector3(0,  10f, 0), ForceMode.Impulse);
                is_on_ground = false;
            }
            if (Input.GetKey("c"))
            {
                transform.localScale = new Vector3(transform.localScale.x, 0.6740307f, transform.localScale.z);

            }
            else
            {
               transform.localScale = new Vector3(transform.localScale.x, original, transform.localScale.z);
            }
        }
        

        if (current_health <= 0)
        {
            Time.timeScale = 0f;
            is_active = false;
            gameoverui.SetActive(true);
        }
        

        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            is_on_ground = true;
        }
        
    }


    





}
