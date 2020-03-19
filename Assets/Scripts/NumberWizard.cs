using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] Text guessText;
    [SerializeField] TextMeshProUGUI successText;

    static int guess;
    static int numberOfGuesses;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        numberOfGuesses = 0;
        NextGuess();
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }

    public void OnPressSuccess()
    {
        successText.text = "I correctly guessed " + guess.ToString() + " after " + numberOfGuesses.ToString() + " tries!";
    }

    void NextGuess()
    {
        numberOfGuesses = numberOfGuesses + 1;
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}