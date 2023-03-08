using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    float randomRotate;

    Color randomColor;
    float waitT = 1f;
    void Start()
    {
        float randomScale = Random.Range(.5f, 3.5f);
        randomRotate = Random.Range(20.0f, 45.0f);

        Vector3 randomPos = new Vector3(Random.Range(0.0f, 10f), Random.Range(0.0f, 10f), Random.Range(0.0f, 10f));

        transform.position = randomPos;
        transform.localScale = Vector3.one * randomScale;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);

    }
    
    void Update()
    {
        Material material = Renderer.material;

        if (waitT > 0f)
        {
            waitT -= Time.deltaTime;
        }
        if (waitT <= 0f)
        {
            Color randomColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            material.SetColor("_Color", randomColor);
            waitT = 1f;
        }
        transform.Rotate(randomRotate * Time.deltaTime, 0.0f, 0.0f);

        Restart();
    }


    void Restart()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
        }
    }
}
