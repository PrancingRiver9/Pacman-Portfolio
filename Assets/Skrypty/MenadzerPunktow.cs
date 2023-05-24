using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenadzerPunktow : MonoBehaviour
{
    public int punkty;
    public TextMeshProUGUI punktyNaInterfejsie;

    private void Update()
    {
        punktyNaInterfejsie.text = punkty.ToString();
    }
    public void DodajPunkt()
    {
        punkty++;
        punktyNaInterfejsie.text = punkty.ToString();
    }
}
