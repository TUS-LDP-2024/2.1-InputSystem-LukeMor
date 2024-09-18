using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleController : MonoBehaviour
{
    private GameInputController _inputs;
    public float growStep;

    // Start is called before the first frame update
    void Start()
    {
        _inputs = GetComponent<GameInputController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_inputs.grow)
        {
            Vector3 currentScale = transform.localScale;

            currentScale.y = Mathf.Clamp(currentScale.y + (growStep * Time.deltaTime), 0.1f, 5.0f);
            //currentScale.y = currentScale.y + (growStep * Time.deltaTime);
            transform.localScale = currentScale;
        }
    }
}
