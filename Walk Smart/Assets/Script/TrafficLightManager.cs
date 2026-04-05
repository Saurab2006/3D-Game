using UnityEngine;
using System.Collections;

public class TrafficLightManager : MonoBehaviour
{
    public RedLight redLight;
    public YellowLight yellowLight;
    public GreenLight greenLight;

    void Start()
    {
        StartCoroutine(Cycle());
    }

    IEnumerator Cycle()
    {
        while (true)
        {
            redLight.TurnOn();
            yellowLight.TurnOff();
            greenLight.TurnOff();
            yield return new WaitForSeconds(3f);

            redLight.TurnOff();
            yellowLight.TurnOn();
            greenLight.TurnOff();
            yield return new WaitForSeconds(2f);

            redLight.TurnOff();
            yellowLight.TurnOff();
            greenLight.TurnOn();
            yield return new WaitForSeconds(3f);
        }
    }
}