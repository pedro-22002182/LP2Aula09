using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerController : MonoBehaviour
{
    private IEnumerable<Superpower> powersList;

    // Start is called before the first frame update
    void Start()
    {
        powersList = GetComponents<Superpower>();
        StartCoroutine(chamarPower());
    }

    private IEnumerator chamarPower()
    {

        YieldInstruction wfs = new WaitForSeconds(5);
        while(true)
        {
            foreach(Superpower poder in powersList)
            {
                poder.Activate();
            }

            yield return wfs;
        }
    }
}
