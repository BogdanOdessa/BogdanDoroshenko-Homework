using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Debug;

namespace Game
{
<<<<<<< Updated upstream:Bogdan_Unity_OOP/Assets/Scripts/Player.cs
    public class Player : MonoBehaviour, ISpeedChange, IDisposable
    {

        private Rigidbody _body;

        [SerializeField] private float currentSpeed;
        private float _initialSpeed = 300f;
=======
    public sealed class Player : PlayerBase, IDisposable
    {

        private Rigidbody _body;
        private Material _material;

        private bool _isGrounded;

        public float Speed { get; private set; }

        private Color _initialColor;

        #region
        //[SerializeField] private float currentSpeed;
>>>>>>> Stashed changes:Bogdan_Unity_OOP/Assets/Scripts/Player/Player.cs

        //private readonly float _initialSpeed = 3f;

        //private PlayerSpeed _playerSpeed;

        //[SerializeField] private float _rotationSpeed;

        //[SerializeField] private float _jumpForce;

        //private float _vertical;

        //private float _horizontal;

<<<<<<< Updated upstream:Bogdan_Unity_OOP/Assets/Scripts/Player.cs
        private float _timeForBonus = 10f;
        [SerializeField] private float _bonusTime;
=======
        //private bool _isBonusPicked = false;
>>>>>>> Stashed changes:Bogdan_Unity_OOP/Assets/Scripts/Player/Player.cs

        //private readonly float _timeForBonus = 7f;
        //[SerializeField] private float _bonusTime;

        // currentSpeed = _initialSpeed;
        //_bonusTime = _timeForBonus;
        //_playerSpeed = new PlayerSpeed();
        //currentSpeed = _playerSpeed.СurrentSpeed;
        #endregion

        void Awake()
        {
<<<<<<< Updated upstream:Bogdan_Unity_OOP/Assets/Scripts/Player.cs

            _body = GetComponent<Rigidbody>();
            currentSpeed = _initialSpeed;
            _bonusTime = _timeForBonus;
=======
            _material = GetComponent<Renderer>().material;
            _initialColor = GetComponent<Renderer>().material.color;
            _body = GetComponent<Rigidbody>(); 
>>>>>>> Stashed changes:Bogdan_Unity_OOP/Assets/Scripts/Player/Player.cs
            Log("Have a good game ^_^");
        }
        public void SetSpeed(float speed)
        {
            Speed = speed;
        }

        public void SetColor(Color color)
        {
<<<<<<< Updated upstream:Bogdan_Unity_OOP/Assets/Scripts/Player.cs
            if (isBonusPicked)
            {
                
                _bonusTime -= Time.deltaTime;
                if (_bonusTime < 0f)
                {
                    SpeedNormal();
                    _bonusTime = _timeForBonus;
                    isBonusPicked = false;
                   
                }
            } 
            
=======
            _material.color = color;
>>>>>>> Stashed changes:Bogdan_Unity_OOP/Assets/Scripts/Player/Player.cs
        }

        public void Die(object value, Color color)
        {
            Dispose();
            Log("Game Over -_-");
        }
        public void Dispose()
        {
<<<<<<< Updated upstream:Bogdan_Unity_OOP/Assets/Scripts/Player.cs
            vertical = Input.GetAxis("Vertical");
            horizontal = Input.GetAxis("Horizontal");
            if (Input.GetAxis("Jump") > 0)
            {
                if (_isGrounded)
                {
                    _body.AddForce(transform.up * _jumpForce);
                }
            }
            Vector3 velocity = (transform.forward * vertical) * currentSpeed * Time.fixedDeltaTime;
            velocity.y = _body.velocity.y;
            _body.velocity = velocity;
            transform.Rotate((transform.up * horizontal) * _rotationSpeed * Time.fixedDeltaTime);
=======
            //gameObject.SetActive(false);
            Destroy(gameObject);
>>>>>>> Stashed changes:Bogdan_Unity_OOP/Assets/Scripts/Player/Player.cs
        }

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag(("Ground")))
            {
                _isGrounded = true;
            }
        }
        void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject.CompareTag(("Ground")))
            {
                _isGrounded = false;
            }
        }

        public override void Move(float x, float y, float z, float jumpforce)
        {
            _body.AddForce(new Vector3(x, y, z) * Speed);
            if (_isGrounded)
            {
                _body.AddForce(new Vector3(x, jumpforce, z)); // Jump
            }
        }

        #region
        /*private void Update()
        {
            if (_isBonusPicked)
            {
                _bonusTime -= Time.deltaTime;
                if (_bonusTime < 0f)
                {
                    SpeedNormal();
                    ColorNomral();
                    _bonusTime = _timeForBonus;
                    _isBonusPicked = false;
                   
                }
            } 
            
        }*/
        //void FixedUpdate()
        //{
        //    vertical = Input.GetAxis("Vertical");
        //    horizontal = Input.GetAxis("Horizontal");
        //    if (Input.GetAxis("Jump") > 0)
        //    {
        //        if (_isGrounded)
        //        {
        //            _body.AddForce(transform.up * _jumpForce);
        //        }
        //    }
        //    Vector3 velocity = (transform.forward * vertical) * currentSpeed * Time.fixedDeltaTime;
        //    velocity.y = _body.velocity.y;
        //    _body.velocity = velocity;
        //    transform.Rotate((transform.up * horizontal) * _rotationSpeed * Time.fixedDeltaTime);
        //}

        /*public void SpeedIncrease()
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
        }*/

        //public void GetBonus()
        //{
        //    _isBonusPicked = true;
        //}

        //public void SetSpeedToNormal()
        //{
        //    _playerSpeed.SpeedNormal();
        //}

        //public void ChangeColorToBadEffect()
        //{
        //    _material.color = Color.yellow; /*Color.Lerp(Color.red, Color.yellow, 10);*/
        //}

        //public void ColorNomral()
        //{
        //    _material.color = _initialColor;
        //}

        //public void ChangeColorToGoodEffect()
        //{
        //    _material.color = Color.green;
        //}

        //void OnCollisionEnter(Collision collision)
        //{
        //    if (collision.gameObject.CompareTag(("Ground")))
        //    {
        //        _isGrounded = true;
        //    }
        //}
        //void OnCollisionExit(Collision collision)
        //{
        //    if (collision.gameObject.CompareTag(("Ground")))
        //    {
        //        _isGrounded = false;
        //    }


        //    #region
        //    //{
        //    //    public float Speed = 3.0f;
        //    //    private Rigidbody _rigidbody;
        //    //    public float rotsp = 50f;
        //    //    private float moveHorizontal;
        //    //    private float moveVertical;

        //    //    [SerializeField]private float _rotationSpeed = 20f;
        //    //    private float _speedToRotate = 0f;
        //    //    public float _horizontalRotation = 0f;


        //    //    private void Start()
        //    //    {
        //    //        _rigidbody = GetComponent<Rigidbody>();
        //    //    }

        //    //    protected void Move()
        //    //    {
        //    //        moveHorizontal = Input.GetAxis("Horizontal");
        //    //        moveVertical = Input.GetAxis("Vertical");

        //    //        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //    //        _rigidbody.AddForce(movement * Speed);


        //    //    }

        //    //    private void Update()
        //    //    {
        //    //        //if (Input.GetKey(KeyCode.Q))
        //    //        //{
        //    //        //    _horizontalRotation = -1;
        //    //        //    _speedToRotate = _rotationSpeed;
        //    //        //}
        //    //        //else if (Input.GetKey(KeyCode.E))
        //    //        //{
        //    //        //    _horizontalRotation = 1;
        //    //        //    _speedToRotate = _rotationSpeed;
        //    //        //}
        //    //        //else
        //    //        //{
        //    //        //    _horizontalRotation = 0;
        //    //        //    _speedToRotate = 0;
        //    //        //}
        //    //    }

        //    //    private void FixedUpdate()
        //    //    {
        //    //        //moveHorizontal = Input.GetAxis("Horizontal");
        //    //        //moveVertical = Input.GetAxis("Vertical");
        //    //        //_rigidbody.velocity = (transform.forward * moveVertical) * Speed * Time.fixedDeltaTime;
        //    //        //transform.Rotate((transform.up * moveHorizontal) * _rotationSpeed * Time.fixedDeltaTime);
        //    //        Move();
        //    //        //transform.Rotate(transform.up * _horizontalRotation * _rotationSpeed * Time.fixedDeltaTime);
        //    //    }
        //    #endregion
        //}
        #endregion


<<<<<<< Updated upstream:Bogdan_Unity_OOP/Assets/Scripts/Player.cs
        public void Die()
        {
            Dispose();
            Log("Game Over -_-");
        }
        public void Dispose()
        {
            Destroy(gameObject);
        }
=======
>>>>>>> Stashed changes:Bogdan_Unity_OOP/Assets/Scripts/Player/Player.cs
    }
}
    

