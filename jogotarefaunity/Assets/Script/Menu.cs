using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string nomeCena;
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        //ativando painel do menu
        Panel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //função do botão start
    public void StartGame()
    {
        //carregando a cena Game
        SceneManager.LoadScene(nomeCena);
    }
    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
