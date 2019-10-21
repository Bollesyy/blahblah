using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glasses : MonoBehaviour
{

   public static bool areGlassesEquiped;
    // Start is called before the first frame update
    void Start()
    {
        makeGlassesFalse();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q) && !areGlassesEquiped)
        {
            EquipGlasses();
        }

        else if (Input.GetKeyDown(KeyCode.Q) && areGlassesEquiped)
        {
            TakeOffGlasses();
        }
    }

    void EquipGlasses()
    {
        Debug.Log("Equipped glases");
        makeGlassesTrue();
    }

    void TakeOffGlasses()
    {
        Debug.Log("Took off glases");
        makeGlassesFalse();
    }

    void makeGlassesFalse()
    {
        areGlassesEquiped = false;
    }

    void makeGlassesTrue()
    {
        areGlassesEquiped = true;
    }
}
