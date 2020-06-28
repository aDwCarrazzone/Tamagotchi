using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Registration : MonoBehaviour
{
    public InputField       usernameField;
    public InputField       passwordField;
    public InputField       confirmPasswordField;
    public InputField       emailField;
    public InputField       confirmEmailField;
    public InputField       countryField;
    public InputField       nameField;
    public InputField       genderField;

    public Button           submitButton;

    public void CallRegister()
    {
        StartCoroutine(Register());
    }

    IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        form.AddField("username",   usernameField.text);
        form.AddField("password",   passwordField.text);
        form.AddField("email",      emailField.text);
        form.AddField("country",    countryField.text);
        form.AddField("name",       nameField.text);
        form.AddField("gender",     genderField.text);

        WWW www = new WWW("http://localhost/Tamagochi/sqlconnect/register.php", form);
        yield return www;
        if (www.text == "0")
        {
            UnityEngine.Debug.Log("User created successfully.");
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        else
        {
            UnityEngine.Debug.Log("User creating failed. Error #" + www.text);
        }
    }

    public void VerifyInputs()
    {
        submitButton.interactable = (
            usernameField.text.Length   >= 4 &&
            passwordField.text.Length   >= 4 && 
            confirmPasswordField.text   == passwordField.text && 
            emailField.text.Length      >= 8 && 
            confirmEmailField.text      == emailField.text && 
            countryField.text.Length    >= 3 &&
            nameField.text.Length       >= 2 && 
            genderField.text.Length     >= 4
        );
    }

}
