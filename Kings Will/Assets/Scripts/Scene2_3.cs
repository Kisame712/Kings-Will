using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2_3 : MonoBehaviour
{
    [SerializeField] float fadeInScreenTime;

    [Header("UI Elements")]
    public GameObject fadeInScreen;
    public GameObject textBox;
    public TMP_Text textArea;
    public GameObject continueButton;
    public TMP_Text charName;
    public GameObject choicePanel1_1;

    [Header("Scene Characters")]
    public GameObject charGeneralRich;
    public GameObject charPrinceCarl;

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
        charName.text = "Prince Carl";
        textArea.text = "";
        fadeInScreen.SetActive(false);
        charPrinceCarl.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "Edgar, do you need something from us? Shouldn't you be more worried about your own future?";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);

    }

    IEnumerator EventTwo()
    {
        // eventCount 1
        charPrinceCarl.SetActive(false);
        charName.text = "General Rich";
        textArea.text = "";
        textBox.SetActive(false);
        charGeneralRich.SetActive(true);
        continueButton.SetActive(false);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "Unfortunately, I don't have any 'important announcement' to make.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventThree()
    {
        // eventCount 2
        charGeneralRich.SetActive(false);
        charName.text = "Prince Carl";
        textArea.text = "";
        textBox.SetActive(false);
        charPrinceCarl.SetActive(true);
        continueButton.SetActive(false);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "Hahaha... Oh father you jest!";
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
        string sentence = "Hey father, come to think of it, do you think I have any chance of becoming the king?";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventFive()
    {
        // eventCount 4
        charPrinceCarl.SetActive(false);
        charName.text = "General Rich";
        textArea.text = "";
        continueButton.SetActive(false);
        charGeneralRich.SetActive(true);
        textBox.SetActive(false);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "My son, as much as I would like to see you king, it is just not going to happen. The king's own children best you at both brain and brawn. Which brings me to Edgar. What about you?";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);

    }

    IEnumerator EventSix()
    {
        // eventCount 5
        continueButton.SetActive(false);
        charGeneralRich.SetActive(false);
        charName.text = "Prince Edgar";
        textArea.text = "";
        string sentence = "In all honesty, I would just ask of you both to refrain from violence after the ascension ceremony. As you already know, Brother Carl won't be the king.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventSeven()
    {
        // eventCount 6
        continueButton.SetActive(false);
        charName.text = "Prince Carl";
        textArea.text = "";
        charPrinceCarl.SetActive(true);
        textBox.SetActive(false);
        yield return new WaitForSeconds(2f);
        textBox.SetActive(true);
        string sentence = "How rude! I know you are smart and will be pulling some strings. How about we make a deal? I will endorse you for kingship if it needs be, and in return you ensure my family's safety in the future.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }


    IEnumerator EventEight()
    {
        // eventCount 7
        charPrinceCarl.SetActive(false);
        charName.text = "Prince Edgar";
        textArea.text = "";
        continueButton.SetActive(false);
        string sentence = "I see. Do you hate the idea of Brother Luke or Sister Anna being the next ruler that much?";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventNine()
    {
        // eventCount 8
        continueButton.SetActive(false);
        charName.text = "General Rich";
        textArea.text = "";
        charGeneralRich.SetActive(true);
        textBox.SetActive(false);
        yield return new WaitForSeconds(2f);
        textBox.SetActive(true);
        string sentence = "I prefer you over Luke. My son too has no problem it seems. Anna is a dangerous and selfish woman. This deal may be the best outcome for all of us involved.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventTen()
    {
        // eventCount 9
        continueButton.SetActive(false);
        textArea.text = "";
        string sentence = "I wasn't able to get the throne because I was young. I would be happy to see you live my dream. The rest is upto you young ones. I shall take my leave.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventEleven()
    {
        // eventCount 10
        continueButton.SetActive(false);
        textArea.text = "";
        string sentence = "(Leaves)";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventTwelve()
    {
        // eventCount 11
        charGeneralRich.SetActive(false);
        continueButton.SetActive(false);
        charName.text = "Prince Carl";
        textArea.text = "";
        textBox.SetActive(false);
        charPrinceCarl.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "Just between us two, I have always hated cunning ones like you. But I am willing to concede this time. Even if Luke is chosen, I am sure he won't harm his family. I want you to stop Anna.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventThirteen()
    {
        //eventCount 12
        charPrinceCarl.SetActive(false);
        continueButton.SetActive(false);
        charName.text = "Prince Edgar";
        textArea.text = "";
        continueButton.SetActive(false);
        string sentence = "I will see what I can do. I shall be off then.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);

    }

    IEnumerator EventFourteen()
    {
        // eventCount 13
        continueButton.SetActive(false);
        textBox.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        choicePanel1_1.SetActive(true);
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
        }

    }

    public void LoadScene3Variant(int index)
    {
        SceneManager.LoadScene($"Scene3_3_{index}");
    }
}
