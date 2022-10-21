using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Client : MonoBehaviour
{
    public bool IhasLeg;
    public bool ICanSwim;
    public bool IEdible;

    public Toggle Leg;
    public Toggle Swim;
    public Toggle Edi;
    public Text text1;

    public void OnPress()
    {
        AnimalRequirement requirements = new AnimalRequirement();
        requirements.hasLeg = Leg.isOn;
        requirements.CanSwim = Swim.isOn;
        requirements.Edible = Edi.isOn;
        IAnimal k = GetAnimal(requirements);
        text1.text = k.ToString();
        Debug.Log(k);
    }
    // Start is called before the first frame update

    // Update is called once per frame

    private static IAnimal GetAnimal(AnimalRequirement requirements)
    {
        AnimalFactory factory = new AnimalFactory(requirements);
        return factory.Create();
    }
}
