using UnityEngine;
using System.Linq;

public class QuestionGenerator : MonoBehaviour
{
     public MathQuestion GenerateAddition()
    {
        int a = Random.Range(1, 11);
        int b = Random.Range(1, 11);

        int correct = a + b;

        int wrong1 = correct + Random.Range(1, 4);
        int wrong2 = correct - Random.Range(1, 4);
        int wrong3 = correct + Random.Range(5, 9);

        int[] choices = new int[] { correct, wrong1, wrong2, wrong3 }
            .OrderBy(x => Random.value).ToArray(); // shuffle

        return new MathQuestion
        {
            questionText = $"What is {a} + {b} ?",
            correctAnswer = correct,
            choices = choices
        };
    }
  
}
