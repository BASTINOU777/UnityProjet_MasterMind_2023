using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private AppManager _appManager;
    private Board _board;
    void Start()
    {
        _appManager = FindObjectOfType<AppManager>();
        _board =FindObjectOfType<Board>();
    }

    // Update is called once per frame
    void Update()
    {
        CastRay();

    }
    void CastRay()         // on clik sur la pawn il peut changer la color
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //j'utilise le ray pour récup points d'impac (hit)
            if (Physics.Raycast(ray, out hit))
            {
                //si je touche un getcomponent 
                if (hit.collider.GetComponent<Pawn>() != null)
                {
                    Debug.Log("je click sur le pawn!");
                    hit.collider.GetComponent<Pawn>().ChangeColor();
                }
            }
        }
    }

}
