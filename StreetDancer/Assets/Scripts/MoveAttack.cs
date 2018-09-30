using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAttack : MonoBehaviour {

    public float attackSpeed = 7f;
    public float timeEnd = 0.5f;
    public int direction = 1;

    private float time = 0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(direction * attackSpeed, 0f, 0f) * Time.fixedDeltaTime;
        time += Time.deltaTime;
        if (timeEnd < time)
        {
            Destroy();
        }
    }

    public void Destroy()
    {
        Object.Destroy(gameObject);
    }
}
