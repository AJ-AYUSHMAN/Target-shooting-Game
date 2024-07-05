using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        Debug.Log("HIT");
        GameplayManager.instance.IncrementScore();
        Destroy(gameObject);
    }
}
