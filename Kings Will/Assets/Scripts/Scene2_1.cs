using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2_1 : MonoBehaviour
{
    [SerializeField] float fadeInScreenTime;

    [Header("UI Elements")]
    public GameObject fadeInScreen;
    public GameObject textBox;
    public TMP_Text textArea;
    public GameObject continueButton;
    public TMP_Text charName;
    public GameObject choicePanel1_1;
    public GameObject choicePanel2_1;

    [Header("Scene Characters")]
    public GameObject charPrinceLuke;
    public GameObject charPrincessSophie;

    [Header("Miscellaneuos")]
    public float typeSpeed;

    string currText = "";
    private int eventCount = 0;
    private int accept = 0;

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
        charName.text = "Prince Luke";
        fadeInScreen.SetActive(false);
        charPrinceLuke.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "Both my youngest siblings are here.. Were you that worried for me? I don't know what to do at times like these. It was the same when mother died...";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);

    }

    IEnumerator EventTwo()
    {
        // eventCount 1
        charPrinceLuke.SetActive(false);
        charName.text = "Princess Sophie";
        textArea.text = "";
        continueButton.SetActive(false);
        textBox.SetActive(false);
        charPrincessSophie.SetActive(true);
        continueButton.SetActive(false);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "Brother Luke, I know you need time to compose yourself but I want you to hear me out.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventThree()
    {
        // eventCount 2
        textArea.text = "";
        continueButton.SetActive(false);
        string sentence = "I have always hated my royal status. I have no interest in the throne or the riches. I just want to be left alone with my books..";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventFour()
    {
        // eventCount 3
        textArea.text = "";
        continueButton.SetActive(false);
        string sentence = "To be more clear, if either of you meet father, please convey my message. I will pray for father and your good health.";
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
        string sentence = "(Leaves the room)";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);

    }

    IEnumerator EventSix()
    {
        // eventCount 5
        charPrincessSophie.SetActive(false);
        charName.text = "Prince Edgar";
        textArea.text = "";
        continueButton.SetActive(false);
        string sentence = "Brother Luke, please forgive my rudeness but I must ask about your decision. I must also share my thoughts.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventSeven()
    {
        // eventCount 6
        continueButton.SetActive(false);
        textBox.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        choicePanel1_1.SetActive(true);
    }


    IEnumerator EventEight()
    {
        // eventCount 7
        accept = 1;
        choicePanel1_1.SetActive(false);
        charName.text = "Prince Luke";
        textArea.text = "";
        continueButton.SetActive(false);
        textBox.SetActive(false);
        charPrinceLuke.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "... I see. So you wish to become the next ruler. I am glad you said that to me directly. Since childhood, I was raised to be strong as the eldest son to takeover father's throne.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventNine()
    {
        // eventCount 8
        textArea.text = "";
        continueButton.SetActive(false);
        string sentence = "However, I came to realize, I am not fit to be a king. I may be strong physically, but I lack your intelligence. I do feel like you are a kind and capable person.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventTen()
    {
        // eventCount 9
        textArea.text = "";
        continueButton.SetActive(false);
        string sentence = "Very well then! You have my endorsement. I would meet father tomorrow and convey our thoughts. Good night Edgar.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventEleven()
    {
        // eventCount 10
        charPrinceLuke.SetActive(false);
        charName.text = "Prince Edgar";
        textArea.text = "";
        continueButton.SetActive(false);
        string sentence = "Thank you Brother Luke! I shall be off then.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventTwelve()
    {
        // eventCount 11
        continueButton.SetActive(false);
        textBox.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        choicePanel2_1.SetActive(true);
    }

    IEnumerator EventThirteen()
    {
        //eventCount 12
        choicePanel1_1.SetActive(false);
        charName.text = "Prince Luke";
        textArea.text = "";
        continueButton.SetActive(false);
        textBox.SetActive(false);
        charPrinceLuke.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "You don't desire the throne you say. I think that is waste. You have a good brain fit for a king, unlike me. Among all other siblings, I trust you the most.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);

    }

    IEnumerator EventFourteen()
    {
        // eventCount 13
        textArea.text = "";
        continueButton.SetActive(false);
        string sentence = "With times changing, it is not uncommon for elder daughters to take the throne. Sophie aside, Anna is.. I could never get a read on her.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventFifteen()
    {
        // eventCount 14
        textArea.text = "";
        continueButton.SetActive(false);
        string sentence = "As for Carl, he is too arrogant. At the very least, I hope father sees what I see. I will be discussing things with father tomorrow. Good night Edgar.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);

    }

    IEnumerator EventSixteen()
    {
        // eventCount 15
        charPrinceLuke.SetActive(false);
        charName.text = "Prince Edgar";
        textArea.text = "";
        continueButton.SetActive(false);
        string sentence = "Thank you Brother Luke! I shall be off then.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventSeventeen()
    {
        // eventCount 16
        continueButton.SetActive(false);
        textBox.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        choicePanel2_1.SetActive(true);

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
                StartCoroutine(EventFourteen());
                break;
            case 14:
                StartCoroutine(EventFifteen());
                break;
            case 15:
                StartCoroutine(EventSixteen());
                break;
            case 16:
                StartCoroutine(EventSeventeen());
                break;
        }

    }

    public void LoadScene3Variant(int index)
    {
        SceneManager.LoadScene($"Scene3_{accept}_{index}");
    }

    public void AcceptKingShip()
    {
        eventCount = 7;
    }

    public void RejectKingShip()
    {
        eventCount = 12;
    }

}
