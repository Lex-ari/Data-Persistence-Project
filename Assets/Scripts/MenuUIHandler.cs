using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{

    public TMP_InputField usernameInput;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    public void StartNew() {
        string username = usernameInput.text;
        DataManager.Instance.username = username;
        SceneManager.LoadScene(1);
	}
}
