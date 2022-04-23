using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField] private GameObject CalcScreen;
    [SerializeField] private GameObject CompScreen;

    private GameObject currentScreen;

    private void Start()
    {
        CalcScreen.SetActive(true);
        currentScreen = CalcScreen;
    }

    public void ChangeState(GameObject state)
    {
        if (currentScreen != null)
        {
            currentScreen.SetActive(false);
            state.SetActive(true);
            currentScreen = state;
        }
    }
}
