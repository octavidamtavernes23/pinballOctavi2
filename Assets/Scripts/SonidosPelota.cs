using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SonidosPelota : MonoBehaviour
{
    public AudioSource moneda;
    public AudioSource diana;
    private int punts=0;
    public int duros = 0;
    public Text Puntos;
    

    void OnCollisionEnter (Collision otro)
    {
        if (otro.gameObject.CompareTag("monedes"))
        {
            duros= duros +1;
            punts=punts+5000;
            moneda.Play();
            //Destroy(otro.gameObject);
            
            //GameObject.FindGameObjectsWithTag("tag");
            otro.gameObject.SetActive (false);
            actualizarmarcador();
        }
        if (otro.gameObject.CompareTag("dianes1"))
        {
            punts = punts +2000;
            diana.Play();
            actualizarmarcador();

        }
        if (otro.gameObject.CompareTag("dianes2"))
        {
           punts = punts +10000;
            diana.Play();
            actualizarmarcador();
            
            
        }
     
 }
    public void Awake()
    {
        actualizarmarcador();
    }
    public void FixedUpdate()
    {
        actualizarmarcador();
    }

    private void actualizarmarcador()
    {
        
        Puntos.text= "Puntos: " + punts;
    }
     
       
}
