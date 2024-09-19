using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    //EJERCICIO 4: Variables para controlar la velocidad de movimiento y la fuerza del salto
    public float movementSpeed = 1, jumpForce = 1;

    //EJERCICIO 4: Componente Rigidbody2D del Player
    private Rigidbody2D rbody;

    //EJERCICIO 4: Verifica si el Player está en el suelo
    private bool isGrounded;
    void Start()
    {
        //EJERCICIO 4: Obtiene el componente Rigidbody2D al inicio
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //EJERCICIO 4: Actualiza la velocidad horizontal del Player
        rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * movementSpeed, rbody.velocity.y);
        //EJERCICIO 4: Verifica si se presiona la tecla de espacio para saltar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    
    private void Jump()
    {
        //EJERCICIO 4: Verifica si el Player está en el suelo antes de saltar
        if (isGrounded)
        {
            //EJERCICIO 4: Cambia la velocidad vertical para que el Player salte
            rbody.velocity = new Vector2(rbody.velocity.x, jumpForce);
            //EJERCICIO 4: Indica que el Player ya no está en el suelo
            isGrounded = false;
        }
    }

    //EJERCICIO 4: Método que se llama cuando el Player colisiona con otro objeto
    private void OnCollisionEnter2D(Collision2D other)
    {
        //EJERCICIO 4: Verifica si el objeto con el que choca tiene la etiqueta "Floor"
        if (other.gameObject.CompareTag("Floor"))
        {
            //EJERCICIO 4: Establece isGrounded en true, permitiendo que el Player salte nuevamente
            isGrounded = true;
        }
    }
}