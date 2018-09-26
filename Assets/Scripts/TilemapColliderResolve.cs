using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TilemapColliderResolve : MonoBehaviour
{
    public Text debugText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        debugText.text = "TRIGGER ENTER";
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        debugText.text = "TRIGGER EXIT";
    }
}
