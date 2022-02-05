using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneController : MonoBehaviour
{
    [SerializeField] private InputField inputFieldTermA, inputFieldTermB;
    [SerializeField] private Text txtResult;
    private int termA, termB;

    public int CheckAddition(int summandA, int summandB)
    {
        int result = 0;

        result = summandA + summandB;

        Debug.Log(result);
        txtResult.text = string.Format("{0}", result);
        return result;
    }
    void Start()
    {
        Debug.Log("Start");
    }

    public void GetValues()
    {
        /* 
         if(Regex.IsMatch(inputFieldTermA.text, @"^\d+$") && Regex.IsMatch(inputFieldTermB.text, @"^\d+$")) 
        //?berpr?ft ob in den Inputboxxen ein Zahlenwert steht
        {
            termA = int.Parse(inputFieldTermA.text);
            termB = int.Parse(inputFieldTermB.text);
        }
        else
        {
            termA = 0;
            termB = 0;
        }
        */


        termA = int.Parse(inputFieldTermA.text);
        termB = int.Parse(inputFieldTermB.text);

        CheckAddition(termA, termB); //ruft die Additionsfunktion auf
    }

    public void ResetAll()
    {
        txtResult.text = "";
        inputFieldTermA.text = "";
        inputFieldTermB.text = "";
        termA = 0;
        termB = 0;
    }
    void Update()
    {

    }
}
