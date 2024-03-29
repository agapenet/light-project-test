using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool isInRange;

    public KeyCode interactKey;
    public UnityEvent interactAction;
    public GameObject interactTip;

    public GameObject buttonLight;

    void Start()
    {

    }

    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                Debug.Log("Interaction");
                interactAction.Invoke();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("In range");
            isInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Out of range");
            isInRange = false;
        }
    }

    public void buttonLightToggle ()
    {
        if (buttonLight.activeInHierarchy == false)
        {
            buttonLight.SetActive(true);
        }
    }
}
