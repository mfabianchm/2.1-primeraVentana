using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PrimeraVentana : MonoBehaviour
{
    
    public TextMeshProUGUI numberText;
    public string Url;
    public string Url2;
    public string Url3;


    int counter;

    public void IncrementCount() {
        counter++;
        numberText.text = counter + "";
    } 

     public void DecrementCount() {
        counter--;
        numberText.text = counter + "";
    } 

    public void RestartCount() {
        counter = 0;
        numberText.text = counter + "";
    } 

    public void OpenURL1() {
        Application.OpenURL(Url);
    }

    public void OpenURL2() {
        Application.OpenURL(Url2);
    }

    public void OpenURL3() {
        Application.OpenURL(Url3);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
