using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene4_Luke : MonoBehaviour
{
    [SerializeField] float fadeInScreenTime;

    [Header("UI Elements")]
    public GameObject fadeInScreen;
    public GameObject textBox;
    public TMP_Text textArea;
    public GameObject continueButton;
    public TMP_Text charName;

    [Header("Scene Characters")]
    public GameObject charKingJames;
    public GameObject charGeneralRich;
    public GameObject charPrinceLuke;
    public GameObject charPrinceCarl;
    public GameObject charPrincessAnna;
    public GameObject charPrincessSophie;

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
        charName.text = "King James";
        textArea.text = "";
        fadeInScreen.SetActive(false);
        charKingJames.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "I am happy to see you all assemble before me. As you already know, I am an inch closer to death and not in good health. I shall be announcing my successor who shall carry on my will.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);

    }

    IEnumerator EventTwo()
    {
        // eventCount 1
        continueButton.SetActive(false);
        textArea.text = "";
        string sentence = "Luke! You shall be the next king!";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventThree()
    {
        // eventCount 2
        charKingJames.SetActive(false);
        continueButton.SetActive(false);
        charName.text = "Prince Luke";
        textArea.text = "";
        textBox.SetActive(false);
        charPrinceLuke.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "I am honoured father! I promise to follow your will at all times.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventFour()
    {
        // eventCount 3
        continueButton.SetActive(false);
        charPrinceLuke.SetActive(false);
        charName.text = "Prince Edgar";
        textArea.text = "";
        string sentence = "Congratulations Brother Luke! I am happy for you!";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventFive()
    {
        // eventCount 4
        continueButton.SetActive(false);
        charName.text = "General Rich";
        textArea.text = "";
        textBox.SetActive(false);
        charGeneralRich.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "Congratulations..";
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
        charName.text = "Princess Anna";
        textArea.text = "";
        textBox.SetActive(false);
        charPrincessAnna.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "Hmmm.. I am still not convinced by the King's decision but congratulations nonetheless.";
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
        charName.text = "Prince Carl";
        textArea.text = "";
        textBox.SetActive(false);
        charPrinceCarl.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "Congratulations Luke...";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }


    IEnumerator EventEight()
    {
        // eventCount 7
        continueButton.SetActive(false);
        charPrinceCarl.SetActive(false);
        charName.text = "Princess Sophie";
        textArea.text = "";
        textBox.SetActive(false);
        charPrincessSophie.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "Congratulations Brother Luke. I am sure you would make a great king with Brother Edgar by your side.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventNine()
    {
        // eventCount 8
        continueButton.SetActive(false);
        charPrincessSophie.SetActive(false);
        charName.text = "King James";
        textArea.text = "";
        charKingJames.SetActive(true);
        textBox.SetActive(false);
        yield return new WaitForSeconds(2f);
        textBox.SetActive(true);
        string sentence = "Luke! I wish you would be open to taking valuable advise from your siblings.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventTen()
    {
        // eventCount 9
        charKingJames.SetActive(false);
        continueButton.SetActive(false);
        charName.text = "Prince Luke";
        textArea.text = "";
        textBox.SetActive(false);
        charPrinceLuke.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "Surely father! I wish times were better but I want us all to have a meal together. Is that okay?";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventEleven()
    {
        // eventCount 10
        charPrinceLuke.SetActive(false);
        continueButton.SetActive(false);
        charName.text = "King James";
        textArea.text = "";
        textBox.SetActive(false);
        charKingJames.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "Hahaha.. Yes surely. King Luke.";
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
                LoadScene1();
                break;

        }

    }

    public void LoadScene1()
    {
        SceneManager.LoadScene("Main Menu");
    }
}