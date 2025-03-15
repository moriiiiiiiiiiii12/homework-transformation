using UnityEngine;

public class Scaller : MonoBehaviour
{
    [SerializeField] private float _speedScaller;

    private void Update()
    {
        transform.localScale += Vector3.one * _speedScaller * Time.deltaTime;
    }
}
