using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Pawns : MonoBehaviour
{
    [SerializeField] private AppManager _appManager;
    [SerializeField] private GameObject _pawn;
    private int _actualColorNumber = -1;
    private Collider _collider;
    private void Start()
    {
        _collider = GetComponent<Collider>();

    }
    public void ActivatePawn()
    {
        _collider.enabled = true;
    }
    public void DesactivatePawn()
    {
        _collider.enabled = false;
    }

    // fonction pour changer la couleur du pion 
    public void PawnChangeColor()
    {

        if (_actualColorNumber == -1 || _actualColorNumber >= _appManager._answerColors.Length - 1)
        {
            _actualColorNumber = 0;
        }
        else
        {
            _actualColorNumber++;
        }
        GetComponent<MeshRenderer>().material.SetColor("_Color", _appManager._answerColors[_actualColorNumber]);
    }
    public void PawnChangeColor(int resultColorNumber)
    {
        GetComponent<MeshRenderer>().material.SetColor("_Color", _appManager._resultColors[resultColorNumber]);
    }

}



















//function pour trouver la position de pawn à partir du raycast de la main camera
//    private Vector3 RaycastPawn()
//    {
//        // new vector3 pour transmettre les position du Game object 
//        Vector3 PawnPos = new Vector3(_pawn.transform.position.x, _pawn.transform.position.y, _pawn.transform.position.z);
//        // au raycast je localise pawn 
//        Vector3 Direction = PawnPos - _pawn.transform.position;
//        // 
//        Debug.DrawRay(_pawn.transform.position, Direction * 20f, Color.red);
//        if
//        {
//        RaycastHit GetComponent<Collider>() != null
//        return RaycastPawn;
//        }
//}
//function pour afficher la couleur du pawn au over de la sourie 
//    private void OnMouseOver()
//    {

//    }

//    public void PawnChangeColor(Material mat)
//    {
//        GetComponent<MeshRenderer>().material = mat;
//    }

//}


