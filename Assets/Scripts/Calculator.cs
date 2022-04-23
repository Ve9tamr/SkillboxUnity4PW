using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    private float _FirstNumber;
    private float _SecondNumber;
    private float _ResultingNumber;
    public InputField _FirstText;
    public InputField _SecondText;
    public Text _ResultingText;

    public void CalculateSum()
    {
        if (float.TryParse(_FirstText.text, out _FirstNumber))
        {
            if (float.TryParse(_SecondText.text, out _SecondNumber))
            {
                _ResultingNumber = _FirstNumber + _SecondNumber;
                _ResultingText.text = (_ResultingNumber).ToString();
            }
            else
            {
                _ResultingText.text = " ";
            }
        }
        else
        {
            _ResultingText.text = " ";
        }
    }

    public void CalculateDifference()
    {
        if (float.TryParse(_FirstText.text, out _FirstNumber))
        {
            if (float.TryParse(_SecondText.text, out _SecondNumber))
            {
                _ResultingNumber = _FirstNumber - _SecondNumber;
                _ResultingText.text = (_ResultingNumber).ToString();
            }
            else
            {
                _ResultingText.text = " ";
            }
        }
        else
        {
            _ResultingText.text = " ";
        }
    }

    public void CalculateProduct()
    {
        if (float.TryParse(_FirstText.text, out _FirstNumber))
        {
            if (float.TryParse(_SecondText.text, out _SecondNumber))
            {
                _ResultingNumber = _FirstNumber * _SecondNumber;
                _ResultingText.text = (_ResultingNumber).ToString();
            }
            else
            {
                _ResultingText.text = " ";
            }
        }
        else
        {
            _ResultingText.text = " ";
        }
    }

    public void CalculateDivision()
    {
        if (float.TryParse(_FirstText.text, out _FirstNumber))
        {
            if (float.TryParse(_SecondText.text, out _SecondNumber))
            {
                _ResultingNumber = _FirstNumber / _SecondNumber;
                _ResultingText.text = (_ResultingNumber).ToString();
            }
            else
            {
                _ResultingText.text = " ";
            }
        }
        else
        {
            _ResultingText.text = " ";
        }
    }
}
