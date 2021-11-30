using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    private IEnumerable<AnimalsAI> listAnimals;

    // Start is called before the first frame update
    void Start()
    {
        listAnimals = new AnimalsAI[] {new SheepAI(), new WolfAI()};

        StartCoroutine(chamarTakeTurn());
    }

    private IEnumerator chamarTakeTurn()
    {
        while(true)
        {
            yield return new WaitForSeconds(2);

            foreach(AnimalsAI animal in listAnimals)
            {
                animal.TakeTurn();
            }
        }
    }
}
