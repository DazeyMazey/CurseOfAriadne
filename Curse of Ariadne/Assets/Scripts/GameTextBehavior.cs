using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Class for getting the text from the input, sending it to the game, and then displaying it on the game board.
public class GameTextBehavior : MonoBehaviour
{
    private InputField field;
    public Text textbars;


    // Start is called before the first frame update
    void Start()
    {
        field = GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // add send command to game later
            textbars.text += "\n> " + field.text;
            field.text = "";
            field.ActivateInputField();
        }
    }
}
