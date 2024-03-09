using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLessonCode : MonoBehaviour
{
    // Deðiþkenler

    // Cümle, paragraf, isim, özel ad...= String
    // sayý,rakam...= Ýnt
    // Küsüratlý sayý,ondalýklý sayý... = Float,Double
    // Tek Karakter,alfabe... = char
    // Ýki seçenekli durumlar / doðru-yanlýþ= bool
    string adým = "Ali";
    string soyadým = "BALTAKESEN";
    string universitem = "Atatürk Üniversitesi";
    string adres = "Yunus Emre Mah. Sincan/Ankara";
    char cinsiyetim = 'E';
    int yasým = 31;
    int kilo = 72;
    int boy = 164;
    float sonuc;
    int Endeks;
    int faktoriyel;
    
    int toplam;
    int cift;
    int tek;

    bool hayattamý = true;

    private void Start()
    {
        Debug.Log(adým + "  " + soyadým + "  " + adres);

        if (cinsiyetim == 'E')
        {
            Debug.Log("Erkek");
        }
        else
        {
            Debug.Log("Kýz");
        }

        boykiloendeks();
        sayi();

    }
    private void boykiloendeks()
    {
        if (Endeks == sonuc)
        {
            sonuc = kilo * boy;

        }
        Debug.Log(Endeks);


    }
    private void sayi()
    {
        for (int i = 0; i < 100; i++)
        {
            toplam = i;
            Debug.Log("1'den 100'e kadar" + toplam);
        }
        for (int i = 0; i < 100;)
        {
            cift = i += 2;
            Debug.Log("çiftler" + cift);
        }
        for (int i = -1; i < 99;)
        {
            tek = i += 2;
            Debug.Log("tekler" + tek);
        }
       

    }
}