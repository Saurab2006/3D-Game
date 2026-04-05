using UnityEngine;

public class YellowLight : MonoBehaviour
{
    public GameObject lightObject;

    public void TurnOn()
    {
        lightObject.SetActive(true);
    }

    public void TurnOff()
    {
        lightObject.SetActive(false);
    }
}