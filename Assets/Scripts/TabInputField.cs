using System.Collections;
using TMPro;
using System.Collections.Generic;
using UnityEngine; 

public class TabInputField : MonoBehaviour
{
   public TMP_InputField HeightOfRefObj; //0
   public TMP_InputField LenghtOfRefObj; //1
   public TMP_InputField PosX; //2
   public TMP_InputField PosY; //3
   public TMP_InputField Height; //4
   public TMP_InputField Lenght; //5

   public void HeightOfRefObjSelected() => InputSelected = 0;
   public void LenghtOfRefObjSelected() => InputSelected = 1;
   public void PosXSelected() => InputSelected = 2;
   public void PosYObjSelected() => InputSelected = 3;
   public void HeightSelected() => InputSelected = 4;
   public void LenghtSelected() => InputSelected = 5;

   public int InputSelected;

   private void Update()
   {
        if(Input.GetKeyDown(KeyCode.Tab) && Input.GetKey(KeyCode.LeftShift)) 
        {
            InputSelected--;
            if (InputSelected < 0) InputSelected = 5; 
            SelectInputField();
        }
        else if (Input.GetKeyDown(KeyCode.Tab))
        {
            InputSelected++;
            if (InputSelected > 5) InputSelected = 0; 
            SelectInputField();
        }

        void SelectInputField()
        {
            switch (InputSelected)
            {
                case 0: HeightOfRefObj.Select();
                    break;
                case 1: LenghtOfRefObj.Select();
                    break;   
                case 2: PosX.Select();
                    break;
                case 3: PosY.Select();
                    break;  
                case 4: Height.Select();
                    break;
                case 5: Lenght.Select();
                    break; 
            }
        }

    }

}
