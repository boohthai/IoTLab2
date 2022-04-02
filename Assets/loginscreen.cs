using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using M2MqttUnity;

public class loginscreen : MonoBehaviour
{
    public InputField BrokerUrl;
    public InputField Username;
    public InputField Password;
    public Button ConnectButton;
    private string url;
    private string username;
    private string password;
    // Start is called before the first frame update

    void Start()
    {
        ConnectButton.onClick.AddListener(ConnectServer);
    }

    // Update is called once per frame
    void Update()
    {
        OnTab();

        url = BrokerUrl.text;
        username = Username.text;
        password = Password.text;
    }

    private void OnTab()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (BrokerUrl.isFocused) Username.Select();
            if (Username.isFocused) Password.Select();
            if (Password.isFocused) BrokerUrl.Select();
        }
    }

    private void ConnectServer()
    {
        if (url == "" || username == "" || password == "")
        {
            print("Please enter something");
            return;
        }
        print("Connecting...");
    }
}
