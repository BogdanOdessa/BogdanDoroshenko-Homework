using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Debug;

namespace Game
{
    public sealed class Player : PlayerBase, ISpeedChange, IDisposable
    {

        private Rigidbody _body;
        private Material _material;
        private Color _initialColor;

       [SerializeField] private float currentSpeed;
        private readonly float _initialSpeed = 3f;

        [SerializeField] private float _rotationSpeed;

        [SerializeField] private float _jumpForce;

        private float vertical;

        private float horizontal;

        private bool _isGrounded;

        private bool isBonusPicked = false;

        private readonly float _timeForBonus = 7f;
        [SerializeField] private float _bonusTime;


        void Start()
        {
            _material = GetComponent<Renderer>().material;
            _initialColor = GetComponent<Renderer>().material.color;
            _body = GetComponent<Rigidbody>();
            currentSpeed = _initialSpeed;
            _bonusTime = _timeForBonus;
            Log("Have a good game ^_^");
        }

        private void Update()
        {
            if (isBonusPicked)
            {
                
                _bonusTime -= Time.deltaTime;
                if (_bonusTime < 0f)
                {
                    SpeedNormal();
                    ColorNomral();
                    _bonusTime = _timeForBonus;
                    isBonusPicked = false;
                   
                }
            } 
            
        }
        void FixedUpdate()
        {
            //vertical = Input.GetAxis("Vertical");
            //horizontal = Input.GetAxis("Horizontal");
            //if (Input.GetAxis("Jump") > 0)
            //{
            //    if (_isGrounded)
            //    {
            //        _body.AddForce(transform.up * _jumpForce);
            //    }
            //}
            //Vector3 velocity = (transform.forward * vertical) * currentSpeed * Time.fixedDeltaTime;
            //velocity.y = _body.velocity.y;
            //_body.velocity = velocity;
            //transform.Rotate((transform.up * horizontal) * _rotationSpeed * Time.fixedDeltaTime);
        }
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == ("Ground"))
            {
                _isGrounded = true;
            }
        }
        void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject.tag == ("Ground"))
            {
                _isGrounded = false;
            }

            #region
            //{
            //    public float Speed = 3.0f;
            //    private Rigidbody _rigidbody;
            //    public float rotsp = 50f;
            //    private float moveHorizontal;
            //    private float moveVertical;

            //    [SerializeField]private float _rotationSpeed = 20f;
            //    private float _speedToRotate = 0f;
            //    public float _horizontalRotation = 0f;


            //    private void Start()
            //    {
            //        _rigidbody = GetComponent<Rigidbody>();
            //    }

            //    protected void Move()
            //    {
            //        moveHorizontal = Input.GetAxis("Horizontal");
            //        moveVertical = Input.GetAxis("Vertical");

            //        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            //        _rigidbody.AddForce(movement * Speed);


            //    }

            //    private void Update()
            //    {
            //        //if (Input.GetKey(KeyCode.Q))
            //        //{
            //        //    _horizontalRotation = -1;
            //        //    _speedToRotate = _rotationSpeed;
            //        //}
            //        //else if (Input.GetKey(KeyCode.E))
            //        //{
            //        //    _horizontalRotation = 1;
            //        //    _speedToRotate = _rotationSpeed;
            //        //}
            //        //else
            //        //{
            //        //    _horizontalRotation = 0;
            //        //    _speedToRotate = 0;
            //        //}
            //    }

            //    private void FixedUpdate()
            //    {
            //        //moveHorizontal = Input.GetAxis("Horizontal");
            //        //moveVertical = Input.GetAxis("Vertical");
            //        //_rigidbody.velocity = (transform.forward * moveVertical) * Speed * Time.fixedDeltaTime;
            //        //transform.Rotate((transform.up * moveHorizontal) * _rotationSpeed * Time.fixedDeltaTime);
            //        Move();
            //        //transform.Rotate(transform.up * _horizontalRotation * _rotationSpeed * Time.fixedDeltaTime);
            //    }
            #endregion
        }

        public void SpeedIncrease()
        {
            currentSpeed *= 2;
        }

        public void SpeedDecrease()
        {
            currentSpeed /= 2;
        }

        public void SpeedNormal()
        {
            currentSpeed = _initialSpeed;
        }

        public void GetBonus()
        {
            isBonusPicked = true;
        }

        public void Die(object value, Color color)
        {
            Dispose();
            Log("Game Over -_-");
        }
        public void Dispose()
        {
            //gameObject.SetActive(false);
            Destroy(gameObject);
        }

        public void ChangeColorToBadEffect()
        {
            _material.color = Color.yellow; /*Color.Lerp(Color.red, Color.yellow, 10);*/
        }

        public void ColorNomral()
        {
            _material.color = _initialColor;
        }

        public void ChangeColorToGoodEffect()
        {
            _material.color = Color.green;
        }

        public override void Move(float x, float y, float z)
        {
            _body.AddForce(new Vector3(x, y, z) * currentSpeed);
        }
    }
}
    
