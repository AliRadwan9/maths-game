using UnityEngine;
using TMPro; 
using UnityEngine.UI;
using System.Collections;

public class UIManager : MonoBehaviour
{
    public TMP_Text questionText;
    public TMP_Text[] buttonTexts;
    public TMP_Text scoreText;
    public Image panelBackground;
    public GameObject[] heartIcons; 
    public GameObject gameOverPanel;
    public TMP_Text finalScoreText;
    public Color normalColor = Color.gray;

    public void UpdateDisplay(MathQuestion question)
    {
        questionText.text = question.questionText;
        for (int i = 0; i < buttonTexts.Length; i++)
        {
            buttonTexts[i].text = question.choices[i].ToString(); 
        }
        
    }
    public void UpdateLives(int remaningLives)
    {
       for (int i = 0; i < heartIcons.Length; i++)
        {
            if (i >= remaningLives)
            {
                heartIcons[i].SetActive(false);
            }
            else
            {
                heartIcons[i].SetActive(true);
            }
        }

    }
    public void UpdateScore(int newScore)
    {
        scoreText.text = newScore.ToString();
    }
    public void ShowGameOver(int finalScore)
    {
        gameOverPanel.SetActive(true);
        finalScoreText.text = "Final Score: " + finalScore;
    }

    public IEnumerator ShowFeedback(bool isCorrect)
    {
        panelBackground.color = isCorrect ? Color.green : Color.red;
        yield return new WaitForSeconds(0.4f);
        panelBackground.color = normalColor;
    }
}