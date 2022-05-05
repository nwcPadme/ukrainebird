using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float _speed;

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(-_speed * Time.deltaTime, 0, 0);
    }
}
