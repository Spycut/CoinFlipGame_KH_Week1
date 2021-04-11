using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
   
    public TextMeshPro largeText;

    public void BtnAction()
    {
       
    }

    private void PickRandomFromList()
    {
    string[] students = new string[] { "Head", "Tails" };
    string randomName = students[Random.Range(0, students.Length)];
    largeText.text = randomName;
    }

}