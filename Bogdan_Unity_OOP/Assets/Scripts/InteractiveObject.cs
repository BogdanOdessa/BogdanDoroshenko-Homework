using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public abstract class InteractiveObject : MonoBehaviour, IInteractable, IAction , System.IDisposable
    {
        protected Color _color;
        //[SerializeField]private GameController _gameController;

        public virtual void Action()
        {
            _color = Random.ColorHSV();
            if (TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = _color;
            }
        }

        public abstract void Interraction();

        //private void Start()
        //{
        //    Action();
           
        //}

        private void OnTriggerEnter(Collider other)
        {

            if (!other.CompareTag("Player"))
            {
                return;
            }
            Interraction();
            //_gameController.Dispose();
            Dispose();
        }

        public void Dispose()
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
}
    
