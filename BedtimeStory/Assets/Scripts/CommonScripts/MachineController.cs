using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineController : MonoBehaviour {

    public GameEvent gameEvent;

    public GameObject[] funs;
    private int funNumber;

    void Start()
    {
        funNumber = Random.Range(0, funs.Length);
    }

    public void StartFun()
    {
        if (funs.Length < funNumber)
            return;
        else
        {
            GameObject fun = Instantiate(funs[funNumber], transform.position, Quaternion.identity);
            gameEvent.Raise();
        }
    }
}
