using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppManager : MonoBehaviour
{
    public Color[] _answerColors;
    public Color[] _resultColors;
    public Material[] _availableColors = new Material[6];

    private void Update()
    {
      /*  if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //j'utilise le ray pour récup points d'impac (hit)
            if (Physics.Raycast(ray, out hit))
            {
                //si je touche un getcomponent 
                if (hit.collider.GetComponent<Pawn>() != null )
                {

                    hit.collider.GetComponent<Pawn>().ChangeColor();
                }
            }

        }*/
    }
}
