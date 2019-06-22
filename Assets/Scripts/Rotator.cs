using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
    public Vector3 rotationBySecond = new Vector3(15, 30, 45);
    void Update()
    {
        transform.Rotate(rotationBySecond * Time.deltaTime);
    }
}
