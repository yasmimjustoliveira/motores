using UnityEngine;

public class Play : MonoBehaviour
{
   private int numero;
   public float velocidade = 240;
  
   
   void Start()
    {
        numero = 0;
    }

    void Update()
    {
       
    //debug.log(numero);
    //numero = numero + 1;
    // Update is called once per frame
     

     if (Input.GetKey(KeyCode.A)) 
     {
         gameObject.transform.position += new Vector3(-velocidade, 0, 0);
     }
      
     if (Input.GetKey(KeyCode.D))
     {
       gameObject.transform.position += new Vector3(velocidade, 0, 0);
     }


    }


}