using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Item : MonoBehaviour
{
    public Contador contador;
    void Start()
    {
        contador = GameObject.FindGameObjectWithTag("Player").GetComponent<Contador>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            contador.Cantidad = contador.Cantidad + 1;
            Destroy(gameObject);
            if(contador.Cantidad == 5)
            {
                FinJuego();
            }

        }
            
    }

    public void FinJuego()
    {
        SceneManager.LoadScene("Fin");
    }

}
