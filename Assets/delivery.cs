using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delivery : MonoBehaviour
{
     bool gotPackage = false;
     [SerializeField] float destroyDelay = 0.1f;
     [SerializeField] int timeToDeliver = 30;
     [SerializeField] Color32 gotPackageColour = new Color32(1, 1, 1, 1);
     [SerializeField] Color32 noPackageColour = new Color32(1, 1, 1, 1);
     SpriteRenderer spriteRenderer;
     void Start()
     {
          spriteRenderer = GetComponent<SpriteRenderer>();
     }
     // void OnDeliveryEnter2D(Collision2D other) 
     // {
     //     //lives-=5;
     //     gotPackage=true;
     //     Debug.Log("you picked up the package");      
     // }
     void OnTriggerEnter2D(Collider2D other)
     {
          if (other.tag == "package" && !gotPackage)
          {
               spriteRenderer.color = gotPackageColour;
               gotPackage = true;
               Debug.Log("you picked up the package");
               Destroy(other.gameObject, destroyDelay);

          }
          if (other.tag == "delivery_adress" && gotPackage)
          {
               spriteRenderer.color = noPackageColour;
               gotPackage = false;
               Debug.Log("donuts deliverd :D");
          }

     }
}
