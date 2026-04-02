using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public MeshRenderer kart;
    public MeshFilter kartFilter; 
    public GameObject[] karts;

    public float speed = 35f;
    private int currentIndex = 0;



    void Start()
    {
        for (int i = 0; i < karts.Length; i++)
        {
            karts[i].SetActive(i == 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        karts[currentIndex].transform.Rotate(new Vector3(0, 1, 0) * speed * Time.deltaTime);
    }

    public void PlayGame()
    {

        SceneManager.LoadSceneAsync("Main");

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Previous()
    {

        karts[currentIndex].SetActive(false);
        currentIndex = (currentIndex - 1) % karts.Length;
        karts[currentIndex].SetActive(true);
    }

    public void Next()
    {
        karts[currentIndex].SetActive(false);
        currentIndex = (currentIndex + 1) % karts.Length;
        karts[currentIndex].SetActive(true);
    }

    
}
