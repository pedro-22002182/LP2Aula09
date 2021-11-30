using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerController : MonoBehaviour
{
    [SerializeField]
    private List<Superpower> powersList;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(chamarPower());
    }

    private IEnumerator chamarPower()
    {
        while(true)
        {
            yield return new WaitForSeconds(5);

            foreach(Superpower poder in powersList)
            {
                poder.Activate();
            }
        }
    }
}
