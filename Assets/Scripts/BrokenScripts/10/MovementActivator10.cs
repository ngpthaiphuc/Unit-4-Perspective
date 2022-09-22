using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator10 : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;
    //Scene 9: add [SerializeField] for otherObjectToActivate
    [SerializeField] GameObject otherObjectToActivate;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Scene 7: Misspelled and not capitalized function names
    private void OnTriggerEnter(Collider other)
    {
        //Scene 10: Change MoveObject9 to MoveObject10 to activate the right script
        objectToActivate.GetComponent<MoveObject10>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject10>().enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        //Scene 10: Change MoveObject9 to MoveObject10 to activate the right script
        objectToActivate.GetComponent<MoveObject10>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject10>().enabled = true;
    }
}
