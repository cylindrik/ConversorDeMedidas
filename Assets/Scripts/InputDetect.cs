using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine.UI;


public class InputDetect : MonoBehaviour
{

    Regex StringVerify = new Regex ("^[0-9]+$"); //Create regex verify
    [SerializeField] private GameObject[] inputHolder;
    [SerializeField] private GameObject heightOfRefObj;
    [SerializeField] private GameObject lenghtOfRefObj;
    [SerializeField] private GameObject distX;
    [SerializeField] private GameObject distY;
    [SerializeField] private GameObject heightOfObj;
    [SerializeField] private GameObject lenghtOfObj;
    [SerializeField] private GameObject popUpCanvas;
    [SerializeField] private GameObject invalidCanvas;
    [SerializeField] private TMP_InputField  MaxY;
    [SerializeField] private TMP_InputField  MinY;
    [SerializeField] private TMP_InputField  MaxX;
    [SerializeField] private TMP_InputField  MinX;

    private List<float> inputs;
    private float valueHORB;
    private float valueLORB;
    private float valuePX;
    private float valuePY;
    private float valueHO;
    private float valueLO;
    
    public void SaveText()
    {
        
        bool verify = true;
        inputs = new List<float>();

        foreach (GameObject item in inputHolder)
        {
            string extract = item.GetComponent<TMP_InputField>().text;
            verify = Verify(extract);
            Debug.Log(extract + " Verify: " + verify);
            if(verify == false)
            {
                GlobalValues.valid = false;
                break;
            }
            else
            {   
                float x =  float.Parse(extract);
                inputs.Add(x);
            }
            
        }
        
        if(verify == false)
        {
            foreach (GameObject item in inputHolder)
            {
                item.GetComponent<TMP_InputField>().text = "";
            }
            invalidCanvas.SetActive(true);
        }
        else
        {
            Convert();
        }
        
    }


    private void Convert()
    { 
        valueHORB =  float.Parse(heightOfRefObj.GetComponent<TMP_InputField>().text);
        valueLORB = float.Parse(lenghtOfRefObj.GetComponent<TMP_InputField>().text);
        valueHO = float.Parse(heightOfObj.GetComponent<TMP_InputField>().text);
        valueLO = float.Parse(lenghtOfObj.GetComponent<TMP_InputField>().text);
        
        valuePX = float.Parse(distX.GetComponent<TMP_InputField>().text) + ((valueLO)/2f);
        valuePY = float.Parse(distY.GetComponent<TMP_InputField>().text) + ((valueHO)/2f);
        

        float xTop = 1 - (((valueHORB - valuePY - valueHO/2))/valueHORB);
        float xBot =  (valueHORB - valueHO - (valueHORB - valuePY - (valueHO/2)))/valueHORB;
        float xLeft = (valueLORB - valueLO - (valueLORB - valuePX - (valueLO/2)))/valueLORB;
        float xRight  = 1 - ((valueLORB - valuePX - (valueLO/2))/ valueLORB);
             
        MaxY.text =  xTop.ToString();
        MinY.text =  xBot.ToString();
        MinX.text =  xLeft.ToString();
        MaxX.text =  xRight.ToString();

        popUpCanvas.SetActive(true);
                
    }
    
    public void Start()
    {
        inputHolder = new GameObject[6];
        inputHolder[0] = heightOfRefObj;
        inputHolder[1] = lenghtOfRefObj;
        inputHolder[2] = distX;
        inputHolder[3] = distY;
        inputHolder[4] = heightOfObj;
        inputHolder[5] = lenghtOfObj;
                
    }

    public bool Verify(string i)
    {
        return Regex.IsMatch(i, "^[0-9]+$");
    }

    public void ClosePopCanvas()
    {
        popUpCanvas.SetActive(false);
    }

    public void CloseInvalidCanvas()
    {
        invalidCanvas.SetActive(false);
    } 
}




