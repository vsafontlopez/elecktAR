using UnityEngine;
using TMPro;

public class CalculoValorResistencia : MonoBehaviour
{
    public Renderer renderBanda1;
    public Renderer renderBanda2;
    public Renderer renderBanda3;
    public Renderer renderBanda4;
    public TextMeshProUGUI txtValorResistencia;

    int numBanda = 0;
    int valueBanda1 = 0;
    int valueBanda2 = 0;
    int valueBanda3 = 0;
    string txtBanda1 = "0";
    string txtBanda2 = "1";
    string txtBanda3 = " Ohm";
    string txtBanda4 = " ± 5%";

    Color[] colores = { new Color32(0,0,0,255),        //0 - Negro
                        new Color32(139,69,19,255),    //1 - Cafe
                        new Color32(255,0,0,255),      //2 - Rojo
                        new Color32(255,125,0,255),    //3 - Naranja
                        new Color32(255,255,0,255),    //4 - Amarillo
                        new Color32(0,128,0,255),      //5 - Verde
                        new Color32(0,30,255,255),     //6 - Azul
                        new Color32(138,43,226,255),   //7 - Morado
                        new Color32(128,128,128,255),  //8 - Gris
                        new Color32(255,255,255,255),  //9 - Blanco
                        new Color32(218,165,32,255),   //10 - Oro
                        new Color32(169,169,169,255)}; //11 - Plata


    public void setBanda(int Banda)
    {
        numBanda = Banda;
    }

    public void setColor(int color)
    {

        switch (numBanda)
        {
            case 1:
                renderBanda1.material.color = colores[color];
                if (color != 0)
                {
                    txtBanda1 = "" + color;
                }
                else
                {
                    txtBanda1 = "";
                }
                valueBanda1 = color;
                setTextValorResistencia();
                break;
            case 2:
                renderBanda2.material.color = colores[color];
                valueBanda2 = color;
                txtBanda2 = "" + color;
                setTextValorResistencia();
                break;
            case 3:
                renderBanda3.material.color = colores[color];
                valueBanda3 = color;
                setTextBanda3(color);
                setTextValorResistencia();
                break;
            case 4:
                renderBanda4.material.color = colores[color];
                if (color == 10)
                {
                    txtBanda4 = " ± 5%";
                }
                else
                {
                    txtBanda4 = " ± 10%";
                }
                setTextValorResistencia();
                break;
        }
    }

    public void setTextValorResistencia()
    {
        if (valueBanda1 == 0 && valueBanda2 == 0)
            txtValorResistencia.text = "0 Ohm" + txtBanda4;
        else
        {
            if (valueBanda1 == 0 && valueBanda3 == 2)
            {
                txtValorResistencia.text = txtBanda2 + "00 Ohms" + txtBanda4;
            }
            else
            {
                if (valueBanda1 == 0 && valueBanda3 == 5)
                {
                    txtValorResistencia.text = txtBanda2 + "00K Ohms" + txtBanda4;
                }
                else
                {
                    if (valueBanda1 == 0 && valueBanda3 == 8)
                    {
                        txtValorResistencia.text = txtBanda2 + "00M Ohms" + txtBanda4;
                    }
                    else
                    {
                        if (valueBanda3 == 2 || valueBanda3 == 5 || valueBanda3 == 8)
                        {
                            txtValorResistencia.text = txtBanda1 + "." + txtBanda2 + txtBanda3 + txtBanda4;
                        }
                        else
                        {
                            txtValorResistencia.text = txtBanda1 + txtBanda2 + txtBanda3 + txtBanda4;
                        }
                    }
                }

            }
        }
    }

    public void setTextBanda3(int color)
    {
        switch (color)
        {
            case 0:
                txtBanda3 = " Ohm";
                break;
            case 1:
                txtBanda3 = "0 Ohms";
                break;
            case 2:
                txtBanda3 = "K Ohms";
                break;
            case 3:
                txtBanda3 = "K Ohms";
                break;
            case 4:
                txtBanda3 = "0K Ohms";
                break;
            case 5:
                txtBanda3 = "M Ohms";
                break;
            case 6:
                txtBanda3 = "M Ohms";
                break;
            case 7:
                txtBanda3 = "0M Ohms";
                break;
            case 8:
                txtBanda3 = "G Ohms";
                break;
            case 9:
                txtBanda3 = "G Ohms";
                break;
        }
    }
}