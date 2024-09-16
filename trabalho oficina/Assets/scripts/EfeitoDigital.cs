using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class EfeitoDigital : MonoBehaviour
{
    private TextMeshProUGUI componenteTexto;
    private AudioSource _audioSource;
    private string mensagemOriginal;
    public bool imprimindo;


    private void Awake()
    {

    }

    private void OnEnable()
    {

    }


    private void OnDisable()
    {

    }

    public void ImprimirMensagem(string msg)
    {

    }

    IEnumerator LetraPorLetra(string msg){}
    

    
}
