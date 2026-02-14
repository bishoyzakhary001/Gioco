using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class collezionabile : MonoBehaviour
{
    public int counter = 0;
    [SerializeField] private Text TS;
    
    public collezionabile(int counter) {
        this.counter = counter;
    }
    public Canvas win;
    public Canvas gameOver;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collezionabile"))
        {
            Destroy(collision.gameObject);
            counter++;
            Debug.Log("Collezionabili: " + counter);
            TS.text = "COLLEZIONABILI: " + counter;
           
        }
       
    }
    public void Destroyobject(string tag)
    {
        GameObject gameObjects = GameObject.FindGameObjectWithTag(tag);
        Destroy(gameObjects);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Gabbia") && counter == 10)
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Pozzo") && counter == 4)
        {
            Destroy(collision.gameObject.GetComponent<Collider2D>());
        }
        if (collision.gameObject.CompareTag("Chiave") && counter == 4)
        {
            Destroy(collision.gameObject);
            Destroyobject("Muro");
        }
        if (collision.gameObject.CompareTag("vittoria"))
        {
            win.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        if (collision.gameObject.CompareTag("Nemico"))
        {
            gameOver.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
