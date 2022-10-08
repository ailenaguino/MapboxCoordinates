using Mapbox.Unity.Location;
using Mapbox.Utils;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RetrieveCoordinates : MonoBehaviour
{
    public TMP_Text Texto;
    public DeviceLocationProviderAndroidNative LocationProvider;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (LocationProvider == null)
        LocationProvider = gameObject.AddComponent<DeviceLocationProviderAndroidNative>();


        Vector2d a = LocationProvider.CurrentLocation.LatitudeLongitude;
        Texto.text = "Lat: " + a.x.ToString() + " - Long: " + a.y.ToString();
    }
}
