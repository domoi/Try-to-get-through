using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetActiveText : MonoBehaviour
{
    public GameObject Die1;

    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2 || SceneManager.GetActiveScene().buildIndex == 3)
        {
            StartCoroutine(instobj(false));
        }
    }
    IEnumerator instobj(bool textdie)
    {
        yield return new WaitForSeconds(0.5f);
        Die1.SetActive(textdie);
    }

}
