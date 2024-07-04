using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    public float velocidadMov = 5.0f;
    public float velocidadRot = 200.0f;

    public Animator animator;
    public float x, y;

    public Rigidbody rb;
    public float fuerzaSalto = 8f;
    public bool puedeSaltar;

    void Start()
    {
        puedeSaltar = false;
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        transform.Rotate(0, x * Time.deltaTime * velocidadRot, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMov);
    }
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis ("Vertical");        

        animator.SetFloat("VelX", x);
        animator.SetFloat("VelY", y);

        if (puedeSaltar == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetBool("salte", true);
                rb.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode.Impulse);
            }
            animator.SetBool("tocaSuelo", true); 
        }
        else
        {
            EstaCayendo();
        }        

    }

    public void EstaCayendo()
    {
        animator.SetBool("tocaSuelo", false);
        animator.SetBool("salte", false);
    }

}
