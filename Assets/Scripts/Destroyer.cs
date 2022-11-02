using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public void DestroyObject()
    {
        Destroy(this.gameObject);
    }
}
