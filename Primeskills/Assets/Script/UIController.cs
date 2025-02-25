using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public Animator animator;
    public string danceAnimationName;
    public CameraMove cameraMain;
    public TextMeshProUGUI Description_TMP;
    public GameObject Panel;
    public GameObject ButtonNext;
    public GameObject ButtonBack;
    public GameObject ButtonClose;

    const string Movement_Text = "Use WASD For Movement";
    const string Close_Text = "Click Close To Play";


    // Start is called before the first frame update
    void Start()
    {
        cameraMain.enabled = false;
        Description_TMP.text = Movement_Text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Dance()
    {
        animator.SetTrigger(danceAnimationName);
    }

    public void Next()
    {
        ButtonNext.SetActive(false);
        ButtonBack.SetActive(true);
        ButtonClose.SetActive(true);

        Description_TMP.text = Close_Text;
    }

    public void Back()
    {
        ButtonBack.SetActive(false);
        ButtonClose.SetActive(false);
        ButtonNext.SetActive(true);

        Description_TMP.text = Movement_Text;
    }

    public void Close()
    {
        Panel.SetActive(false);

        cameraMain.enabled = true;
    }
}
