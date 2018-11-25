using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingStackController : MonoBehaviour {

    public static int slotsOccupied;

    [SerializeField]
    private Transform[] rings;

    [SerializeField]
    private Transform[] initialPositions;

    [SerializeField]
    public float[] finalPositions;

    [SerializeField]
    private GameObject winSign;

    [SerializeField]
    private GameObject wrongSign;

	// Use this for initialization
	void Start () {
        ResetGame();
	}

    private void ResetGame()
    {
        DragRings.PuzzleDone += CheckResults;
        slotsOccupied = 0;
        winSign.SetActive(false);
        wrongSign.SetActive(false);

        for (int i = 0; i < rings.Length; i++)
        {
            rings[i].GetComponent<DragRings>().ResetObject();
        }
    }

    public void CheckResults()
    {
        if (rings[0].position.y == finalPositions[3] &&
            rings[1].position.y == finalPositions[2] &&
            rings[2].position.y == finalPositions[1] &&
            rings[3].position.y == finalPositions[0])
        {
            winSign.SetActive(true);
            //What Next?
        }
        else
        {
            wrongSign.SetActive(true);
            Invoke("ReloadGame", 1f);
        }
    }
    
    private void ReloadGame()
    {
        ResetGame();
        DragRings.PuzzleDone -= CheckResults;

        for (int i = 0; i < rings.Length; i++)
        {
            rings[i].position = initialPositions[i].position;
        }

    }
}
