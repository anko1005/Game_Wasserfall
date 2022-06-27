using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [Range(1f, 20f)]
    Rigidbody _rb;
    public float _moveSpeed = 10f;
    public float _inputHorizontal;
    Vector3 _currentVelocity;

    void Start()
    {
        //transform.LookAt(transform.MovePosition + Vector3.up);
        //transform.localEulerAngles += Vector3.forward * Random.Range(0f, 360f);
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _inputHorizontal = Input.GetAxisRaw("Horizontal");
        _currentVelocity = new Vector3(_inputHorizontal * _moveSpeed, 0f);
        /*MoveForward();
        if (this.transform.position.z > 20)
            Destroy(gameObject);*/
    }

    void FixedUpdate()
    {
        EnemyMoveForward();
        //forwardSpeed += 0.1f * Time.deltaTime;
    }

    void EnemyMoveForward()
    {
        if(_inputHorizontal != 0)
        {
            _rb.velocity = _currentVelocity;
        }
        else
        {
            _currentVelocity = new Vector3(0f, 0f);
            _rb.velocity = _currentVelocity;
        }
        
        
        //Rigidbody.MovePosition() = Rigidbody.MovePosition() + new Vector3(0, 0, _moveSpeed * Time.fixedDeltaTime);
        // Meine Empfehlung:
        // 1) Objekt im FixedUpdate bewegen
        // 2) Rigibody.MovePosition() statt transform.position verwenden!
        // 3) Reminder: Wenn man das Objekt in FixedUpdate bewegt, dann muss man auch Time.fixedDeltaTime verwenden.
        //transform.position = transform.position + new Vector3(0, 0, Speed * Time.deltaTime);

    }


}
