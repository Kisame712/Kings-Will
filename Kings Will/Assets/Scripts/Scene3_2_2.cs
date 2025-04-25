using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene3_2_2 : MonoBehaviour
{
    [SerializeField] float fadeInScreenTime;

    [Header("UI Elements")]
    public GameObject fadeInScreen;
    public GameObject textBox;
    public TMP_Text textArea;
    public GameObject continueButton;
    public TMP_Text charName;

    [Header("Scene Characters")]
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
        charName.text = "Princess Sophie";
        textArea.text = "";
        fadeInScreen.SetActive(false);
        charPrincessSophie.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "Brother Edgar! I just talked to Brother Luke about the will. I have no interest in the throne. I would be relieved if everything is solved without any bloodshed.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);

    }

    IEnumerator EventTwo()
    {
        // eventCount 1
        continueButton.SetActive(false);
        charPrincessSophie.SetActive(false);
        charName.text = "Prince Edgar";
        textArea.text = "";
        string sentence = "I met Sister Anna. She had the tendencies of a tyrant. I would rather not be under her rule.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventThree()
    {
        // eventCount 2
        charName.text = "Princess Sophie";
        textArea.text = "";
        textBox.SetActive(false);
        charPrincessSophie.SetActive(true);
        continueButton.SetActive(false);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "Yes! Certainly. Only you and Brother Luke understand my desires. I don't have any interest in royal traditions, power or money.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventFour()
    {
        // eventCount 3
        charPrincessSophie.SetActive(false);
        charName.text = "Prince Edgar";
        textArea.text = "";
        continueButton.SetActive(false);
        string sentence = "I know Sophie. I want to ensure a peaceful future for all of us. If I become the king, I would fulfil all your wishes as I know you don't have that many to begin with.";
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
        string sentence = "It all comes down to faher's decision in the end. If only there was a way to persuade him..";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);

    }

    IEnumerator EventSix()
    {
        // eventCount 5
        continueButton.SetActive(false);
        charName.text = "Princess Sophie";
        textArea.text = "";
        textBox.SetActive(false);
        charPrincessSophie.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "I know! I will write him a letter tonight. I will convey all our concerns and wishes. It is for the best.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventSeven()
    {
        // eventCount 6
        continueButton.SetActive(false);
        charPrincessSophie.SetActive(false);
        charName.text = "Prince Edgar";
        textArea.text = "";
        string sentence = "... I don't know if it will be effective. How was your conversation with Brother Luke?";
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
        string sentence = "Does he desire the throne? Has he gone back to seclusion just like when mother died?";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventNine()
    {
        // eventCount 8
        continueButton.SetActive(false);
        charName.text = "Princess Sophie";
        textArea.text = "";
        charPrincessSophie.SetActive(true);
        textBox.SetActive(false);
        yield return new WaitForSeconds(2f);
        textBox.SetActive(true);
        string sentence = "He is certainly moved. But he seemed conflicted. He too wants to resolve everything peacefully and is willing to give up his privelage of being the eldest.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventTen()
    {
        // eventCount 9
        charPrincessSophie.SetActive(false);
        continueButton.SetActive(false);
        charName.text = "Prince Edgar";
        textArea.text = "";
        string sentence = "I see. I shall stop overthinking too then. Sophie you should also go to bed. We can only wait for father's decision tomorrow.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventEleven()
    {
        // eventCount 10
        continueButton.SetActive(false);
        charName.text = "Princess Sophie";
        textArea.text = "";
        textBox.SetActive(false);
        charPrincessSophie.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "I have made my decision Brother Edgar. I will ask father to consider you as a candidate. I am sure you will take wise decisions in the future.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventTwelve()
    {
        // eventCount 11
        charPrincessSophie.SetActive(false);
        continueButton.SetActive(false);
        charName.text = "Prince Edgar";
        textArea.text = "";
        string sentence = "I am glad you think so highly of me! I shall leave you to it then. Good night Sophie";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }

    IEnumerator EventThirteen()
    {
        //eventCount 12
        charPrincessSophie.SetActive(false);
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
        SceneManager.LoadScene("Scene4_Edgar");
    }
}
