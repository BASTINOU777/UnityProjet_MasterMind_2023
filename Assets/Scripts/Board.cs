using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR;

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
    [SerializeField] private int _SimilarPawns = -1;
    [SerializeField] private int[] _Goods;
    




    private void Start()
    {

        _appManager = FindObjectOfType<AppManager>();
        GetMaterialColors();
        SetFinalRow();
        ActivateNewLine();
        
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
      //  _finalRow = new int[4];
        for (int i = 0; i < _finalRowPawns.Length; i++)
        {
            // choisir color random
            int Rand = Random.Range(0, _appManager._availableColors.Length);
            // j'attribut un material au hasard a chaques pawns 
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

    //function pour permettre de pas laisser de pawn en selection et de pouvoir commencer la partie au début
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
    // function de vérification des lines 
    public void VerifLines()
    {

        //        }
        //        bool[] answerGoodPlacesTested = new bool[answer.Length];
        //        bool[] answerWrongPlaces = new bool[answer.Length];

        //        int goodAnswer = 0;
        //        int wrongplaces = 0;
        //        for (int i = 0; i < answer.Length; i++)
        //        {
        //            if (answer[i] == _finalRow[i])
        //            {
        //                goodAnswer++;
        //                answerGoodPlacesTested[i] = true;
        //            }
        //        }
        //        for (int i = 0; i < answer.Length; i++)
        //        {
        //            if (!answerGoodPlacesTested[i])
        //            {
        //                for (int j = 0; j < answer.Length; j++)
        //                {
        //                    if (!answerGoodPlacesTested[j] && !answerWrongPlaces[j] && answer[i] == _finalRow[j])
        //                    {
        //                        wrongplaces++;
        //                        answerWrongPlaces[j] = true;
        //                        break;
        //                    }
        //                }
        //            }
        //        }
        //        int[] result = new int[answer.Length];
        //        for (int i = 0; i < answer.Length; i++)
        //        {
        //            if (i < goodAnswer)
        //            {
        //                result[i] = 0;
        //            }
        //            else if (i < (wrongplaces + goodAnswer))
        //            {
        //                result[i] = 1;
        //            }
        //            else
        //            {
        //                result[i] = 2;
        //            }
        //        }
        //        _rows[_actualLine].ApplyResult(result);

        //        if (goodAnswer >= answer.Length)
        //        {
        //            // Unity Event : invocation de l'évent, le ? vérifie si l'évent n'est pas déjà en cours.
        //            OnWin?.Invoke();
        //            return;
        //        }
        //        _actualLine++;

        //        if (_actualLine >= 12)
        //        {
        //            //C# : on invoke l'event. Cette synthaxe correspond à la synthaxe avec le ?. Cela revient au même, vous risquez de trouver les deux
        //            if (OnLoose != null)
        //            {
        //                OnLoose.Invoke();
        //            }

        //        }
        //        else
        //        {
        //            ActivateNewLine();
        //        }

        //    }
    }
}