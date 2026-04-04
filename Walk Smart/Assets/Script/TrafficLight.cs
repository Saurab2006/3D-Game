using UnityEngine;
using System.Collections;

public class TrafficLight : MonoBehaviour
{
    public GameObject redLight;
    public GameObject yellowLight;
    public GameObject greenLight;

    void Start()
    {
        StartCoroutine(TrafficLightCycle());
    }

    IEnumerator TrafficLightCycle()
    {
        while (true)
        {
            // RED
            SetLights(true, false, false);
            yield return new WaitForSeconds(3f);

            // YELLOW
            SetLights(false, true, false);
            yield return new WaitForSeconds(2f);

            // GREEN
            SetLights(false, false, true);
            yield return new WaitForSeconds(3f);
        }
    }

    void SetLights(bool red, bool yellow, bool green)
    {
        redLight.SetActive(red);
        yellowLight.SetActive(yellow);
        greenLight.SetActive(green);
    }
}