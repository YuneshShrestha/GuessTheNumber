using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuessScript : MonoBehaviour
{
    private int randomNumber;
    public InputField inputField;
    public Text outputText;
    public Button guessButton;
    public int minNumber;
    public int maxNumber;

    private void SetRandomNumber() {
        minNumber = GenerateRandomNumber(1, 5);
        maxNumber = GenerateRandomNumber(15, 20);
        randomNumber = GenerateRandomNumber(minNumber, maxNumber);
    }
    // Start is called before the first frame update
    void Start()
    {

        SetRandomNumber();
        outputText.color = Color.yellow;
        outputText.text = "Guess the number between " + minNumber + " and " + maxNumber;
    }
    public void OnGuessButtonPressed() {
        if (inputField.text != "")
        {
            int inputData = int.Parse(inputField.text);
            if (inputData == randomNumber)
            {
                SetRandomNumber();
                outputText.color = Color.green;
                outputText.text = "Correct! "+ "Now, Guess the number between " + minNumber + " and " + maxNumber;
            }
            else if (inputData > randomNumber)
            {
                outputText.color = Color.red;
                outputText.text = "Guessed Number is high!";
            }
            else
            {
                outputText.color = Color.red;
                outputText.text = "Guessed Number is low!";

            }
        }
        else 
        {
            outputText.color = Color.red;
            outputText.text = "Please Enter the Number First!";
        }
        
    }
    private int GenerateRandomNumber(int min, int max) {
        int randomNumber = Random.Range(min,max+1);
        return randomNumber;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
