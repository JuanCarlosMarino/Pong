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

    [Header("Limite inferior:")]
    public float DownLimit;

    [Header("Limite Superior:")]
    public float UpLimit;

    [Header("Controles para GamePad:")]
    [SerializeField] private KeyCode UpControl; 
    [SerializeField] private KeyCode DownControl; 

    private Rigidbody2D _rigidbody2D;

    public Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
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

        //Fuerza de impulso
        //if(!_rigidbody2D.Equals(other: null))
        //    _rigidbody2D.AddForce(Vector2.up,ForceMode2D.Impulse);
        //else
        //{
        //    Debug.LogWarning(message: "El objeto no tiene rigidbody!!!");
        //}

        //limitar en eje y
        transform.position = new Vector3(transform.position.x,Mathf.Clamp(transform.position.y, DownLimit, UpLimit), transform.position.z); 
    }

    public void Reset()
    {
        _rigidbody2D.velocity = Vector2.zero;
        transform.position = startPosition;
    }

    public void ChangeVelocity()
    {
        velocity = velocity * -1;
    }
}