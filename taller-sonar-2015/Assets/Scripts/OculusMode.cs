using UnityEngine;
using System.Collections;

public class OculusMode : MonoBehaviour {
	void Start () {
		UnityEngine.VR.VRSettings.loadedDevice = UnityEngine.VR.VRDeviceType.Oculus;
	}
}

