using UnityEngine;

public class ShowPositions : MonoBehaviour
{
    void Start()
    {
        Debug.Log("LOCAL  = " + transform.localPosition);
        Debug.Log("WORLD  = " + transform.position);
    }
}
