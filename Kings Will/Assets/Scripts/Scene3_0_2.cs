using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene3_0_2 : MonoBehaviour
{
    [SerializeField] float fadeInScreenTime;

    [Header("UI Elements")]
    public GameObject fadeInScreen;
    public GameObject textBox;
    public TMP_Text textArea;
    public GameObject continueButton;
    public TMP_Text charName;

    [Header("Scene Characters")]
    public GameObject charPrinceCarl;
    public GameObject charGeneralRich;

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
        string sentence = "Edgar.. I bet you have a good chance to become the next king";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);

    }

    IEnumerator EventTwo()
    {
        // eventCount 1
        continueButton.SetActive(false);
        charPrinceCarl.SetActive(false);
        charName.text = "Prince Edgar";
        textArea.text = "";
        string sentence = "I have talked to Brother Luke about the will. I will be supporting him as he takes the throne.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventThree()
    {
        // eventCount 2
        charName.text = "Prince Carl";
        textArea.text = "";
        textBox.SetActive(false);
        charPrinceCarl.SetActive(true);
        continueButton.SetActive(false);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "What! You had the chance to be the king didn't you?";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventFour()
    {
        // eventCount 3
        charPrinceCarl.SetActive(false);
        charName.text = "Prince Edgar";
        textArea.text = "";
        continueButton.SetActive(false);
        string sentence = "I can ensure my safety this way. Brother Luke would never harm his own family and he trusts me the most.";
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
        string sentence = "I can control the activities from behind the scenes.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);

    }

    IEnumerator EventSix()
    {
        // eventCount 5
        continueButton.SetActive(false);
        charName.text = "General Rich";
        textArea.text = "";
        textBox.SetActive(false);
        charGeneralRich.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "Not a bad idea. So you desire a peaceful life in the shadows. If it is you beside Luke, we are good with it right son?";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventSeven()
    {
        // eventCount 6
        continueButton.SetActive(false);
        charGeneralRich.SetActive(false);
        charName.text = "Prince Carl";
        textArea.text = "";
        textBox.SetActive(false);
        charPrinceCarl.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "I don't like Luke. I have mixed feelings about this but I guess it is alright. At least we don't have to deal with Anna.";
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
        string sentence = "Very well. I shall be off then.";
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
        string sentence = "(Leaves)";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventTen()
    {
        // eventCount 9
        continueButton.SetActive(false);
        charPrinceCarl.SetActive(false);
        charName.text = "General Rich";
        textArea.text = "";
        textBox.SetActive(false);
        charGeneralRich.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "Don't look so vary. There won't be any violence after the succession. I have had enough violence already.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventEleven()
    {
        // eventCount 10
        charGeneralRich.SetActive(false);
        continueButton.SetActive(false);
        charName.text = "Prince Edgar";
        textArea.text = "";
        string sentence = "That is all I wish. I shall see to it that my uncle's family isn't left behind.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventTwelve()
    {
        // eventCount 11
        continueButton.SetActive(false);
        charName.text = "General Rich";
        textArea.text = "";
        textBox.SetActive(false);
        charGeneralRich.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "Hahaha.. you sure have a way with those words. Go on then. Hope to see you at the courtyard tomorrow.";
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
