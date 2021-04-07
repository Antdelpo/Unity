using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ArduinoScript : MonoBehaviour
{

	SerialPort sp= new SerialPort("/dev/cu.usbmodem1101",9600);
	public float movementModifier;

    // Start is called before the first frame update
    void Start()
    {
	sp.Open();
        	sp.ReadTimeout = 1;
    }

    // Update is called once per frame
    void Update()
    {
       if (sp.ReadyByte() == 1)
	{
 	transform.Translate(Vector3.left)
	}
    }
}
