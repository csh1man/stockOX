using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroscopeInputToggle : MonoBehaviour {

	private bool gyroscopeAvailable;

	// 자이로 센서를 지원하는지 체크.
	void Awake(){
		gyroscopeAvailable = SystemInfo.supportsGyroscope;

		if (!gyroscopeAvailable) {
			Input.gyro.enabled = false;
		} else {
			Input.gyro.enabled = true;
		}
	}
}
