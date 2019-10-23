using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glasses : MonoBehaviour
{

   public static bool areGlassesEquiped;
    void Start()
    {
        makeGlassesFalse();
    }

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
