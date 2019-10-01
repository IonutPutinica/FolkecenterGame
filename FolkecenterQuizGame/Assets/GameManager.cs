using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class GameManager : MonoBehaviour
{
    //this array will store the list of questions
    public Question[] questions;
    private static List<Question> unansweredQuestions;

    private Question currentQuestion;
    [SerializeField]
    private Text factText;

    void Start()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count==0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }

        setCurrentQuestion();
       
        
    }
    void setCurrentQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];
        factText.text = currentQuestion.fact;

        unansweredQuestions.RemoveAt(randomQuestionIndex);
    }

    public void UserSelectTrue()
    {
        if (currentQuestion.isTrue)
        {
            Debug.Log("CORRECT!");
        }
        else
        {
            Debug.Log("WRONG!");
        }
    }


    public void UserSelectFalse()
    {
        if (!currentQuestion.isTrue)
        {
            Debug.Log("CORRECT!");
        }
        else
        {
            Debug.Log("WRONG!");
        }
    }
}
