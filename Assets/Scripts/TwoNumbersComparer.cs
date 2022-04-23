using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoNumbersComparer : MonoBehaviour
{
    private float _FirstNumber;
    private float _SecondNumber;
    public InputField _FirstText;
    public InputField _SecondText;
    public Text _CompareResult;

    public void CompareNumbers()
    {
        if (float.TryParse(_FirstText.text, out _FirstNumber))
        {
            if (float.TryParse(_SecondText.text, out _SecondNumber))
            {
                if (_FirstNumber == _SecondNumber)
                {
                    _CompareResult.text = "Ёти числа равны";
                }
                else if (_FirstNumber > _SecondNumber)
                {
                    _CompareResult.text = $"„исло {_FirstNumber} больше";
                }
                else
                {
                    _CompareResult.text = $"„исло {_SecondNumber} больше";
                }
            }
            else
            {
                _CompareResult.text = "¬ведите второе число";
            }
        }
        else
        {
            _CompareResult.text = "¬ведите первое число";
        }
    }
}
