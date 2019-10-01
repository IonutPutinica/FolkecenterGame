using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class GameManager : MonoBehaviour
{
    //this array will store the list of questions
    public Question[] questions;
    private static List<Question> unansweredQuestions;

    private Question currentQuestion;

    void Start()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count==0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }

        getRandomQuestion();
        Debug.Log(currentQuestion.fact + "is " + currentQuestion.isTrue);
        
    }
    void getRandomQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];
        unansweredQuestions.RemoveAt(randomQuestionIndex);
    }
}
