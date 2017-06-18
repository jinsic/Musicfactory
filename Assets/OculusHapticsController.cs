using UnityEngine;

public class OculusHapticsController : MonoBehaviour
{
    [SerializeField]
    OVRInput.Controller controllerMask;

    private OVRHapticsClip clipLight;
    private OVRHapticsClip clipMedium;
    private OVRHapticsClip clipHard;

    public enum VibrationForce
    {
        Light,
        Medium,
        Hard,
    }

    private void Start()
    {
        InitializeOVRHaptics();
    }


    private void InitializeOVRHaptics()
    {
        // controllerMask = OVRInput.Controller.RTouch;
        int cnt = 100;
        clipLight = new OVRHapticsClip(cnt);
        clipMedium = new OVRHapticsClip(cnt);
        clipHard = new OVRHapticsClip(cnt);
        for (int i = 0; i < cnt; i++)
        {
            clipLight.Samples[i] = i % 2 == 0 ? (byte)0 : (byte)75;
            clipMedium.Samples[i] = i % 2 == 0 ? (byte)0 : (byte)150;
            clipHard.Samples[i] = i % 2 == 0 ? (byte)0 : (byte)255;
        }

        clipLight = new OVRHapticsClip(clipLight.Samples, clipLight.Samples.Length);
        clipMedium = new OVRHapticsClip(clipMedium.Samples, clipMedium.Samples.Length);
        clipHard = new OVRHapticsClip(clipHard.Samples, clipHard.Samples.Length);
    }

    public void Vibrate(VibrationForce vibrationForce)
    {
        UnityEngine.Debug.Log(controllerMask);
        var channel = OVRHaptics.RightChannel;
        if (controllerMask == OVRInput.Controller.LTouch)
        {
            UnityEngine.Debug.Log(controllerMask.ToString());
            channel = OVRHaptics.LeftChannel;
        }

        switch (vibrationForce)
        {
            case VibrationForce.Light:
                channel.Preempt(clipLight);
                break;
            case VibrationForce.Medium:
                channel.Preempt(clipMedium);
                break;
            case VibrationForce.Hard:
                channel.Preempt(clipHard);
                break;
        }


        UnityEngine.Debug.Log(123);
    }
}