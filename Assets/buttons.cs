using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void exitbutton()
    {
        Debug.Log("buttons: на выход");
        Application.Quit();
    }
    public void startbutton()
    {
        Debug.Log("buttons: играем");
        SceneManager.LoadScene(1);
    }
    // void OnMouseDown()
    // {
    //     Debug.Log("buttons: acting");
    //     if (this.name=="start")
    //     {
    //         Debug.Log("buttons: starting");
    //         startbutton();
    //     }
    //     else if (this.name=="exit")
    //     {
    //         Debug.Log("buttons: exiting");
    //         exitbutton();
    //     }
    // }
}
