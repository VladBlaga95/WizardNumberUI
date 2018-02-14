 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NumberWizzard : MonoBehaviour {

    // Use this for initialization
    private int middleValue;
    public int minValue, maxValue;
    public int numberOfGuesses;
    private int previousNumber;
    public Text text;
    public Text Shadow;
	void Start () {
        StartGame();
    }

    // Update is called once per frame
    void Update () {

    }
   public void GuessHigher()
    {
        minValue = middleValue;
        NextGuess();
    }

   public void GuessLower()
    {
        maxValue = middleValue;
        NextGuess();
    }
    void StartGame()
    {
        previousNumber = 0;
        maxValue = maxValue + 1;
        NextGuess();

    }
    void NextGuess()
    {
        Debug.Log(previousNumber + " " + middleValue);
        previousNumber = middleValue;
        middleValue = Random.Range(minValue, maxValue+1);
        Debug.Log(previousNumber + " " + middleValue);
        if (numberOfGuesses == -1)
        {
            SceneManager.LoadScene(2);        // You Win ... out of guesses
        }
        if (previousNumber == middleValue)
        {
            SceneManager.LoadScene(3);
            Debug.Log(previousNumber + " " + middleValue);  //You lose ... I guessed your number 
        }
        text.text = "My guess is " + middleValue + "\n My guess attempts remaining: " + numberOfGuesses;
        Shadow.text = text.text;
        numberOfGuesses--;
    }
    public void RightValue()
    {
        SceneManager.LoadScene(3);
    }

}