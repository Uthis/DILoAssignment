using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour
{
    public bool isClicked = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        isClicked = true;
        gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
    }

    public void OnMouseUp()
    {
        isClicked = false;
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
