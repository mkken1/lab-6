using UnityEngine;
using UnityEngine.SceneManagement;
public class finish : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("finish is here");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("всё пабеда");
            if (this.name=="final")
            {
                SceneManager.LoadScene(0);
            }
            else if (this.name=="finish")
            {
                SceneManager.LoadScene(2);
            }
        }
        else
        {
            Debug.Log("finish: фантомные боли наверное");
        }
    }
}
