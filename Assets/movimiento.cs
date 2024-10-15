using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float speed = 5f;  // Velocidad de movimiento del personaje

    private void Update()
    {
        // Obtener entradas del teclado
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Crear un vector con la dirección del movimiento
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Aplicar el movimiento al personaje
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}
