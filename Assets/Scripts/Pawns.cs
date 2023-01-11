using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;


public class Pawns : MonoBehaviour
{
    [SerializeField] private Collider _collider ;
    [SerializeField] private int _actualColorNumber;
    [SerializeField] private GameObject _pawn;

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
    private void OnMouseOver()
    {

    }

    public void PawnChangeColor(Material mat)
    {
        GetComponent<MeshRenderer>().material = mat;
    }
    
}


