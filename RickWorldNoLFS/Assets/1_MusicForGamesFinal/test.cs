using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [FMODUnity.EventRef] public string _eventSound;
    FMOD.Studio.EventInstance _eventInstance;
    FMOD.Studio.ParameterInstance _myParameter;
    public string _parameter;
    
    // Start is called before the first frame update
    void Start()
    {
        _eventInstance = FMODUnity.RuntimeManager.CreateInstance(_eventSound);
        _eventInstance.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject.transform));
        _eventInstance.getParameter(_parameter, out _myParameter);
        _eventInstance.start();

     
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(transform.position.y);
        _myParameter.setValue(transform.position.y);
        
    }
}
