using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarObjeto : MonoBehaviour
{
    public GameObject objeto;

    public void MostrarObj()
    {
        if (objeto.activeSelf == false)
            objeto.SetActive(true);
        else
            objeto.SetActive(false);
    }

}
