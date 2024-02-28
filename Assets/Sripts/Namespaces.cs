/*using System.Collections;
using System.Collections.Generic;
using System;
using JetBrains.Annotations;
//using UnityEngine;


public class NewBehaviourScript : UnityEngine.MonoBehaviour
{
    // Start is called before the first frame update
    public float value;
    void Start()
    {
        
        void Start()
        {
            float speed = Random.value;
            // …
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/

using UnityEngine;
using System;
using Random = UnityEngine.Random;
public class PlayerMovement : MonoBehaviour
{
    void Start()
    {
        float speed = Random.value;
        // …
    }
}

/*using UnityEngine;
namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        // ...
    }
}*/