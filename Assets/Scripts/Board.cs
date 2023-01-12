using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Board : MonoBehaviour
{
    //Unity Event on déclare l'évent
    public UnityEvent OnWin;

    //Version C# on relie l'appel du delegate à l'event. 
    // La définition du delegate va déterminer quelles informations seront disponibles. 
    // ATTENTION la signature du delegate doit être respectée par les fonctions qui écoutent.
    public delegate void MessageEvent();
    public static event MessageEvent OnLoose;
    [SerializeField] private Row[] _rows;
    [SerializeField] private Pawn[] _finalRowPawns;
    [SerializeField] private AppManager _appManager;
    [SerializeField] private int[] _finalRow;
    [SerializeField] private int _actualLine = 0;
    


    private void Start()
    {

        _appManager = FindObjectOfType<AppManager>();
        GetMaterialColors();
        SetFinalRow();
        ActivateNewLine();
    }
    private void VerifLines()
    {
        // je vérifie si la couleur d'une pawn est égale 
    }
    private void GetMaterialColors()
    {
        _appManager._answerColors = new Color[6];
        for (int i = 0; i < _appManager._availableColors.Length; i++)
        {
            //il prends la couleur du material dans availableColors et je l'asigne au meme index dans answerColors 
            _appManager._answerColors[i] = _appManager._availableColors[i].color;
        }
    }

    private void SetFinalRow()
    {
        _finalRow = new int[4];
        for (int i = 0; i < _finalRow.Length; i++)
        {
            // choisir color random
            int Rand = Random.Range(0, _appManager._availableColors.Length);
            // j'attribut un material  au hasard a chaques pawns 
            _finalRowPawns[i].GetComponent<MeshRenderer>().material = _appManager._availableColors[Rand];
        }
    }
   
    private void ActivateNewLine()
    {
        for (int i = 0; i < _rows.Length; i++)
        {
            if (i == _actualLine)
            {
                _rows[i].ActivateLine();
            }
            else
            {
                _rows[i].DesactivateLine();
            }
        }
    }


    public void CheckActualRow()
    {
        int[] answer = _rows[_actualLine].GetRowColors();
        for (int i = 0; i < answer.Length; i++)
        {
            if (answer[i] == -1)
            {
                return;
            }
        }

    }


}
