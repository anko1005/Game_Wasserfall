using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [Range(1f, 20f)]
    public float Speed = 10f;
    

    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(transform.position + Vector3.up);
        transform.localEulerAngles += Vector3.forward * Random.Range(0f, 360f);
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
        //if (this.transform.position.z > 20)
        //    Destroy(gameObject);
        //forwardSpeed += 0.1f * Time.deltaTime; (wird schneller?)
    }

    void MoveForward()
    {
        // Meine Empfehlung:
        // 1) Objekt im FixedUpdate bewegen
        // 2) Rigibody.MovePosition() statt transform.position verwenden!
        // 3) Reminder: Wenn man das Objekt in FixedUpdate bewegt, dann muss man auch Time.fixedDeltaTime verwenden.
        transform.position = transform.position + new Vector3(0, 0, Speed * Time.deltaTime);
    }


}
