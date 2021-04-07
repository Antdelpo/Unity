using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ArduinoScript : MonoBehaviour
{
	SerialPort sp= new SerialPort("/dev/cu.usbmodem1101",9600);
	public float movementModifier;

    void Start()
    {
	sp.Open();
        sp.ReadTimeout = 1;
    }

    void Update()
    {
       if (sp.ReadyByte() == 1)
	{
 	transform.Translate(Vector3.left * movementModifier);
	}
    }
}
