using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTip : MonoBehaviour
{
    //Con esto activamos el tooltip
    public void ActivarTooltip()
    {
        gameObject.SetActive(true);
    }

    //Con esto desactivamos el tooltip
    public void DesactivarTooltip()
    {
        gameObject.SetActive(false);
    }
}
