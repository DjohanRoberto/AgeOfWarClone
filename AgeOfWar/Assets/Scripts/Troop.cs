using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Troop : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.5f;

    [SerializeField]
    public int bufferLength = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime;

        Vector3 right = new Vector3(100, 0, 0);

        transform.position = Vector3.MoveTowards(transform.position, right , step);

        if (transform.position.x > 28 || transform.position.y < -6) 
        {
            Destroy(this.gameObject);
        }

    }
}
