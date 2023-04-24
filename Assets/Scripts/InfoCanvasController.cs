using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoCanvasController : MonoBehaviour
{
   [SerializeField] private GameObject HORBCanvas;
   [SerializeField] private GameObject LORBCanvas;
   [SerializeField] private GameObject HDISTCanvas;
   [SerializeField] private GameObject VDISTCanvas;
   [SerializeField] private GameObject OBJHCanvas;
   [SerializeField] private GameObject OBJLCanvas;


    public void OpenHeightOfRefOBJCanvas() //Height of Object Canvas
    {
        HORBCanvas.SetActive(true);
    }
    
    public void CloseHeightOfRefOBJCanvas()
    {
        HORBCanvas.SetActive(false);
    }

    public void OpenLenghtOfRefOBJCanvas() //Lenght of Object Canvas
    {
        LORBCanvas.SetActive(true);
    }
    
    public void CloseLenghtOfRefOBJCanvas()
    {
        LORBCanvas.SetActive(false);
    }

    public void OpenHorDistCanvas () // Horizontal distance Canvas
    {
        HDISTCanvas.SetActive(true);
    }
    
    public void CloseHorDistCanvas()
    {
        HDISTCanvas.SetActive(false);
    }

    public void OpenVerDistCanvas() // Vertical distance Canvas
    {
        VDISTCanvas.SetActive(true);
    }
    
    public void CloseVerDistCanvas()
    {
        VDISTCanvas.SetActive(false);
    }

    public void OpenObjHeightCanvas() // Object height Canvas
    {
        OBJHCanvas.SetActive(true);
    }
    
    public void CloseObjHeightCanvas()
    {
        OBJHCanvas.SetActive(false);
    }

    public void OpenObjLenghtCanvas() // Object lenght Canvas
    {
        OBJLCanvas.SetActive(true);
    }
    
    public void CloseObjLenghtCanvas()
    {
        OBJLCanvas.SetActive(false);
    }
}
