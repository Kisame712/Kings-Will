using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Scene1 : MonoBehaviour
{
    [SerializeField] float fadeInScreenTime;

    public GameObject fadeInScreen;
    public GameObject charKingJames;
    public GameObject textBox;
    public GameObject continueButton;
    public TMP_Text textArea;
    public TMP_Text charName;

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
        fadeInScreen.SetActive(false);
        charKingJames.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        string sentence = "I have an important announcement to make. I have been diagnosed with a fatal illness and have only a few days left.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
        
    }

    IEnumerator EventTwo()
    {
        // eventCount 1
        textArea.text = "";
        continueButton.SetActive(false);
        string sentence = "As per the late queen's wishes, I will be choosing a new successor soon and write everyone's duties down in my will.";
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
        string sentence = "Until I make my decision, I would be observing all of you closely. I will be resting in my chamber now. Dismissed.";
        StartCoroutine(Type(sentence));
        yield return new WaitUntil(() => currText == sentence);
        eventCount++;
        continueButton.SetActive(true);
    }
    
    public void ContinueButton()
    {
        if(eventCount == 1)
        {
            StartCoroutine(EventTwo());
        }
        else if(eventCount == 2)
        {
            StartCoroutine(EventThree());
        }
    }


}
