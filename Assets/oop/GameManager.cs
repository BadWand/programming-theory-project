using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Obj Groups")]
    public GameObject[] modes;
    public GameObject[] modeTexts;
    public float modeIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ActivateMode(float index)
    {
        for (int i= 0; i < modes.Length; i++)
        {
            if (i == index)
            {
                modes[i].SetActive(true);
                print(modes[i].gameObject.name);
                print(modeTexts[i].gameObject.name);
                foreach (Transform child in modeTexts[i].transform)
                {
                    child.gameObject.SetActive(true);

                }
            }
            else
            {
                modes[i].SetActive(false);

                foreach (Transform child in modeTexts[i].transform)
                {
                    int x = child.GetSiblingIndex();
                    if  (x != 0)
                        child.gameObject.SetActive(false);

                }
            }
        }

    }
}
