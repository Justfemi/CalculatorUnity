using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class CalculatorController : MonoBehaviour
{
    // public TextMeshProUGUI textFieldText;
    public InputField textField;
    string viewText, tempText, appliedOpt;

    int input_1;
    int input_2;

    bool isOpr = false;

    // Start is called before the first frame update
    public void Start()
    {
        // textField.text = "Hello";
        // textFieldText.text = "Hello";
    }

    // Update is called once per frame
    public void Button_1()
    {
        viewText = viewText + "1";
        textField.text = viewText.ToString();

        if(isOpr)
        {
            tempText = tempText + "1";
        }
    }

    public void Button_2()
    {
        viewText = viewText + "2";
        textField.text = viewText.ToString();

        if(isOpr)
        {
            tempText = tempText + "2";
        }
    }

    public void Button_3()
    {
        viewText = viewText + "3";
        textField.text = viewText.ToString();

        if(isOpr)
        {
            tempText = tempText + "3";
        }
    }

    public void Button_4()
    {
        viewText = viewText + "4";
        textField.text = viewText.ToString();

        if(isOpr)
        {
            tempText = tempText + "4";
        }
    }

    public void Button_5()
    {
        viewText = viewText + "5";
        textField.text = viewText.ToString();

        if(isOpr)
        {
            tempText = tempText + "5";
        }
    }

    public void Button_6()
    {
        viewText = viewText + "6";
        textField.text = viewText.ToString();

        if(isOpr)
        {
            tempText = tempText + "6";
        }
    }

    public void Button_7()
    {
        viewText = viewText + "7";
        textField.text = viewText.ToString();

        if(isOpr)
        {
            tempText = tempText + "7";
        }
    }

    public void Button_8()
    {
        viewText = viewText + "8";
        textField.text = viewText.ToString();

        if(isOpr)
        {
            tempText = tempText + "8";
        }
    }

    public void Button_9()
    {
        viewText = viewText + "9";
        textField.text = viewText.ToString();

        if(isOpr)
        {
            tempText = tempText + "9";
        }
    }

    public void Button_0()
    {
        viewText = viewText + "0";
        textField.text = viewText.ToString();

        if(isOpr)
        {
            tempText = tempText + "0";
        }
    }

    public void clear_Button()
    {
        viewText = tempText = appliedOpt = null;
        input_1 = input_2 = 0;
        isOpr = false;

        textField.text = "";
    }

    public void Opr_Button(string opr)
    {
        input_1 = System.Convert.ToInt32(viewText.ToString());

        if (opr == "+")
        {
            viewText = viewText + "+";
            appliedOpt = "+";
        }

        else if (opr == "x")
        {
            viewText = viewText + "x";
            appliedOpt = "x";
        }

        else if (opr == "-")
        {
            viewText = viewText + "-";
            appliedOpt = "-";
        }

        else if (opr == "/")
        {
            viewText = viewText + "/";
            appliedOpt = "/";
        }
        
        textField.text = viewText.ToString();
        isOpr = true;
    }

    public void Answer_Button()
    {
        input_2 = System.Convert.ToInt32(tempText.ToString());

        if(appliedOpt == "+")
        {
            textField.text = (input_1 + input_2).ToString();
        }

        else if(appliedOpt == "x")
        {
            textField.text = (input_1 * input_2).ToString();
        }

        else if(appliedOpt == "-")
        {
            textField.text = (input_1 - input_2).ToString();
        }

        else if(appliedOpt == "/")
        {
            textField.text = (input_1 / input_2).ToString();
        }
    }
}
