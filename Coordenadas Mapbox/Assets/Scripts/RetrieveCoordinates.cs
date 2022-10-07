using Mapbox.Unity.Location;
using Mapbox.Utils;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RetrieveCoordinates : MonoBehaviour
{
    public static AbstractLocationProvider LocationProvider;
    public TMP_Text Texto;


    // Start is called before the first frame update
    void Start()
    {
        Vector2d a = LocationProvider.CurrentLocation.LatitudeLongitude;
        Texto.text = "Lat: " + a.x.ToString() + " - Long: " + a.y.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
