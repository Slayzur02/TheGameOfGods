using UnityEngine;
using System.Collections;
using Cinemachine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothspeed = 0.125f;
    public Vector3 velocity = Vector3.zero;
    public CinemachineVirtualCamera vcam;
 

    void LateUpdate()
    {
        Vector3 targetPosition = target.TransformPoint(new Vector3(0, 0, -10));
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothspeed);
    }

    public void camShaker(){
        StartCoroutine(camShake());
    }
    private IEnumerator camShake() 
    {
        vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 5f;

        yield return new WaitForSeconds(0.15f);

        vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 2f;

        yield return new WaitForSeconds(0.05f);

        vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 0.0f;

    }

}
