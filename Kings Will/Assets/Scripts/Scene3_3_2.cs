using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene3_3_2 : MonoBehaviour
{
    [SerializeField] float fadeInScreenTime;

    [Header("UI Elements")]
    public GameObject fadeInScreen;
    public GameObject textBox;
    public TMP_Text textArea;
    public GameObject continueButton;
    public TMP_Text charName;

    [Header("Scene Characters")]
    public GameObject charPrincessAnna;

    [Header("Miscellaneuos")]
    public float typeSpeed;

    string currText = "";
    private int eventCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EventOne());
    }

    IEnumerator Type(string sentence)
    {
        foreach (char letter in sentence)
        {
            textArea.text += letter;
            currText = textArea.text;
            yield return new WaitForSeconds(typeSpeed);
        }
    }

    IEnumerator EventOne()
    {
        // eventCount 0
        yield return new WaitForSeconds(fadeInScreenTime);
        charName.text = "Princess Anna";
        textArea.text = "";
        fadeInScreen.SetActive(false);
        charPrincessAnna.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "Edgar, my dear little brother, what brings you here at this time?";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);

    }

    IEnumerator EventTwo()
    {
        // eventCount 1
        continueButton.SetActive(false);
        charPrincessAnna.SetActive(false);
        charName.text = "Prince Edgar";
        textArea.text = "";
        string sentence = "Have you been whispering sweet words to father again? Just so you know, most of us don't want you obtain the throne.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventThree()
    {
        // eventCount 2
        charName.text = "Princess Anna";
        textArea.text = "";
        textBox.SetActive(false);
        charPrincessAnna.SetActive(true);
        continueButton.SetActive(false);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "My my, such consipiracies. I was just being a good daughter to her father and guiding his decisions to reward his daughter accordingly.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventFour()
    {
        // eventCount 3
        charPrincessAnna.SetActive(false);
        charName.text = "Prince Edgar";
        textArea.text = "";
        continueButton.SetActive(false);
        string sentence = "Of course. If you had the power, you would write his will yourself and become the richest woman in the kingdom. Am I wrong?";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventFive()
    {
        // eventCount 4
        textArea.text = "";
        continueButton.SetActive(false);
        string sentence = "The reason you are still unmarried and devoted to father is because you want to keep hoarding his money to buy precious jewellery isn't it? You never loved father. You were always after his wealth!";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);

    }

    IEnumerator EventSix()
    {
        // eventCount 5
        continueButton.SetActive(false);
        charName.text = "Princess Anna";
        textArea.text = "";
        textBox.SetActive(false);
        charPrincessAnna.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "Are you trying to provoke me? You act all innocent but you have been pulling strings all over the castle haven't you? Taking all siblings' side to bully me out of this race, right?";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventSeven()
    {
        // eventCount 6
        continueButton.SetActive(false);
        charPrincessAnna.SetActive(false);
        charName.text = "Prince Edgar";
        textArea.text = "";
        string sentence = "... I have done my part to make sure I am favoured. If you were to somehow get the throne, you would be sending us all off to exile one by one won't you?";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }


    IEnumerator EventEight()
    {
        // eventCount 7
        textArea.text = "";
        continueButton.SetActive(false);
        string sentence = "I am sure someone will report our confrontation to father. Which means both of us would be out of this race. I would happily support Brother Luke.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventNine()
    {
        // eventCount 8
        continueButton.SetActive(false);
        charName.text = "Princess Anna";
        textArea.text = "";
        charPrincessAnna.SetActive(true);
        textBox.SetActive(false);
        yield return new WaitForSeconds(2f);
        textBox.SetActive(true);
        string sentence = "Enough of your nonsense! I knew you were good at pulling strings. I should have known you were doing all this behind my back.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventTen()
    {
        // eventCount 9
        charPrincessAnna.SetActive(false);
        continueButton.SetActive(false);
        charName.text = "Prince Edgar";
        textArea.text = "";
        string sentence = "Now, don't get angry Sister Anna. Am I not your sweet little brother?";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventEleven()
    {
        // eventCount 10
        continueButton.SetActive(false);
        charName.text = "Princess Anna";
        textArea.text = "";
        textBox.SetActive(false);
        charPrincessAnna.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "Very well then. Have it your way. I won't forgive you for interfering, but I will be accepting father's decision.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventTwelve()
    {
        // eventCount 11
        charPrincessAnna.SetActive(false);
        continueButton.SetActive(false);
        charName.text = "Prince Edgar";
        textArea.text = "";
        string sentence = "That is all from me. I shall be going then.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventThirteen()
    {
        //eventCount 12
        charPrincessAnna.SetActive(false);
        continueButton.SetActive(false);
        charName.text = "Prince Edgar";
        textArea.text = "";
        continueButton.SetActive(false);
        string sentence = "(Aside) All that is left is father's decision tomorrow. I think I have done enough.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);

    }



    public void ContinueButton()
    {
        switch (eventCount)
        {
            case 1:
                StartCoroutine(EventTwo());
                break;
            case 2:
                StartCoroutine(EventThree());
                break;
            case 3:
                StartCoroutine(EventFour());
                break;
            case 4:
                StartCoroutine(EventFive());
                break;
            case 5:
                StartCoroutine(EventSix());
                break;
            case 6:
                StartCoroutine(EventSeven());
                break;
            case 7:
                StartCoroutine(EventEight());
                break;
            case 8:
                StartCoroutine(EventNine());
                break;
            case 9:
                StartCoroutine(EventTen());
                break;
            case 10:
                StartCoroutine(EventEleven());
                break;
            case 11:
                StartCoroutine(EventTwelve());
                break;
            case 12:
                StartCoroutine(EventThirteen());
                break;
            case 13:
                LoadScene4();
                break;
        }

    }

    public void LoadScene4()
    {
        SceneManager.LoadScene("Scene4_Luke");
    }
}
