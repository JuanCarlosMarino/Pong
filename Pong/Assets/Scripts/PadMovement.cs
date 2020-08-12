using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Moves the player alongside the y axis
/// </summary>
public class PadMovement : MonoBehaviour
{
    //movement velocity
    [Tooltip("Velocity in unity units!")]
    [SerializeField] private float velocity = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //leer el control        
        //aplicar movimiento
        //mover hacia arriba
        if(Input.GetAxis("Vertical") > 0)
            transform.Translate(x: 0f,y: velocity,z: 0f);
    }
}
