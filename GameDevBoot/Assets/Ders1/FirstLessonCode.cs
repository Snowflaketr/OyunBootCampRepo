using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLessonCode : MonoBehaviour
{
    // De�i�kenler

    // C�mle, paragraf, isim, �zel ad...= String
    // say�,rakam...= �nt
    // K�s�ratl� say�,ondal�kl� say�... = Float,Double
    // Tek Karakter,alfabe... = char
    // �ki se�enekli durumlar / do�ru-yanl��= bool
    string ad�m = "Ali";
    string soyad�m = "BALTAKESEN";
    string universitem = "Atat�rk �niversitesi";
    string adres = "Yunus Emre Mah. Sincan/Ankara";
    char cinsiyetim = 'E';
    int yas�m = 31;
    int kilo = 72;
    int boy = 164;
    float sonuc;
    int Endeks;
    int faktoriyel;
    
    int toplam;
    int cift;
    int tek;

    bool hayattam� = true;

    private void Start()
    {
        Debug.Log(ad�m + "  " + soyad�m + "  " + adres);

        if (cinsiyetim == 'E')
        {
            Debug.Log("Erkek");
        }
        else
        {
            Debug.Log("K�z");
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
            Debug.Log("�iftler" + cift);
        }
        for (int i = -1; i < 99;)
        {
            tek = i += 2;
            Debug.Log("tekler" + tek);
        }
       

    }
}