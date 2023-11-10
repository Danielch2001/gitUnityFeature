using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text comidaNumeroText;

    private int comidaNumero;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddComida()
    {
        comidaNumero = comidaNumero + 1;

        comidaNumeroText.text = comidaNumero.ToString();
    }
}
