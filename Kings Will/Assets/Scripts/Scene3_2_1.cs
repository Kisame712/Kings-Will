using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene3_2_1 : MonoBehaviour
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
        string sentence = "I think I have squashed Anna's chances at least.";
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
        string sentence = "Ahh, that's good! You know how she fakes her nice behaviour in front of the king.";
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
        string sentence = "Yes I do. I have seen it first hand. Forgive my rudeness, but it is not likely you become the next king Brother Carl.";
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
        string sentence = "It is most likely gonna be Brother Luke or me.";
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
        string sentence = "It is still better than Anna getting the throne. I am content with being the general.";
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
        string sentence = "I don't like Luke. Edgar, while I do have some concerns but I will concede. You are the king's own son.";
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
        string sentence = "Whatever happens, happens. I won't waste my time overthinking it. I shall take my leave.";
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
        string sentence = "There is nothing much to say from my side. I will pray for your success.";
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
        string sentence = "Thank you uncle! I hope you will watch over us in absence of father.";
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
        charGeneralRich.SetActive(false);
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
