using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Moves the player alongside the y axis
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class PadMovement : MonoBehaviour
{
    //movement velocity
    [Tooltip("Velocity in unity units!")]
    [SerializeField] private float velocity = 5f;

    [Header("Separacion del sprite con el borde de la pantalla en Y abajo:")]
    public float yOffsetInf;

    [Header("Separacion del sprite con el borde de la pantalla en Y arriba:")]
    public float yOffsetSup;

    [Header("Controles para GamePad:")]
    [SerializeField] private KeyCode UpControl; 
    [SerializeField] private KeyCode DownControl; 

    private Rigidbody2D _rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //leer el control de las teclas        
        //aplicar movimiento
        //mover hacia arriba
        if(Input.GetKey(UpControl))
            transform.Translate(x: 0f,y: velocity,z: 0f);
        //mover hacia abajo
        else if(Input.GetKey(DownControl))
            transform.Translate(x: 0f,y: -velocity,z: 0f);
        if(!_rigidbody2D.Equals(other: null))
            _rigidbody2D.AddForce(Vector2.up,ForceMode2D.Impulse);
        else
        {
            Debug.LogWarning(message: "El objeto no tiene rigidbody!!!");
        }
        //limitar
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, yOffsetInf, yOffsetSup), transform.position.z); 
    }
}
