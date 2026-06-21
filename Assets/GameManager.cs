using UnityEngine;
using TMPro; 
using UnityEngine.UI; 
using System.Collections;

public class GameManager : MonoBehaviour
{
    public QuestionGenerator generator;   
    public UIManager uiManager;
    public int maxLives = 3;

    private MathQuestion currentQuestion;
    private bool isProcessing = false;
    private int score = 0;
    private int remaningLives;
    private bool isGameOver = false;

    void Start()
    {
        // Fix for the red error: Ensure generator is linked
        if (generator == null) generator = GetComponent<QuestionGenerator>();
        
        GenerateNewQuestion();
        remaningLives = maxLives;
    }

    public void GenerateNewQuestion()
    {
        currentQuestion = generator.GenerateAddition();
        uiManager.UpdateDisplay(currentQuestion);

    }


    public void CheckAnswer(int index)
    {
        if (isProcessing || isGameOver) return;
        bool correct = currentQuestion.choices[index] == currentQuestion.correctAnswer;

        if (correct)
        {
            score++;
            uiManager.UpdateScore(score);
            StartCoroutine(HandleAnswerProcess(true));
        }
        else
        {
            remaningLives--;
            uiManager.UpdateLives(remaningLives);

            if (remaningLives <= 0)
            {
                isGameOver = true;
                StartCoroutine(GameOverSequence()); // Show red flash before game over
            }
            else
            {
                StartCoroutine(HandleAnswerProcess(false));
            }    
        }
        
    }

    IEnumerator HandleAnswerProcess(bool correct)
    {
        isProcessing = true;
        // Tell the UI to do the flash and WAIT for it to finish
        yield return StartCoroutine(uiManager.ShowFeedback(correct));

        GenerateNewQuestion();
        isProcessing = false;
    }

    IEnumerator GameOverSequence()
    {
    isProcessing = true;
    yield return StartCoroutine(uiManager.ShowFeedback(false)); 
    
    uiManager.ShowGameOver(score);
    }

}