using UnityEngine;
using System.Collections;
using System;
[Serializable]
public class Jugador : MonoBehaviour
{

   
    private float Range = 1.0f;
    public float speed = 10.0F; //Velocidad de movimiento
    public float rotationSpeed = 10.0F; //Velocidad de rotación
    public int jumpSpeed = 1; //Velocidad de salto
    private bool saltando = false;
    public float Angulo = 80.0f;
    public Rigidbody rb;
  
    

    void Awake()
    {

        

    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.visible = false;
        
   

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {

            speed = 5.0F;

        }
        else
        {
            speed = 3.0F;
        }

        Move(speed, rotationSpeed, jumpSpeed, saltando);
    }




    public void Move(float speed, float rotationSpeed, float jumpSpeed, Boolean Saltando)
    {


        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        Angulo = transform.rotation.eulerAngles.x;

        if (Input.GetKey(KeyCode.W))
        {

            transform.Translate(0, 0, translation * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {

            transform.Translate(-Vector3.forward * speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {

            
            saltando = true;

            transform.Translate(transform.up * jumpSpeed);

            if (Input.GetKeyUp(KeyCode.Space) && saltando)
            {
                transform.Translate(transform.up * jumpSpeed);


            }



        }

        

    }
}
 