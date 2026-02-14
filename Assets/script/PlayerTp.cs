using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTp : MonoBehaviour
{
    private GameObject currentTeleporter;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if(currentTeleporter != null && Vector2.Distance(gameObject.transform.position, currentTeleporter.transform.position) > 0.3f)
        {
            transform.position= currentTeleporter.GetComponent<teleport>().GetDestination().position;
        }
    }
   
       
    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.CompareTag("Teleporter"))
        {
            currentTeleporter = collision.gameObject;
        }
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
         if (collision.CompareTag("Teleporter"))
        {
            if(collision.gameObject==currentTeleporter ) 
            { 
                currentTeleporter=null;
            }
        }
    }

}
