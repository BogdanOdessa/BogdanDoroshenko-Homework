using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public abstract class InteractiveObject : MonoBehaviour, IInteractable, IAction , System.IDisposable, IExecute
    {
        protected Color _color;

        public virtual void Action()
        {
            _color = Random.ColorHSV();
            if (TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = _color;
            }
        }

        public abstract void Interraction();

        public abstract void Execute();

        private void OnTriggerEnter(Collider other)
        {

            if (!other.CompareTag("Player"))
            {
                return;
            }
            Interraction();
            Dispose();
        }

        public void Dispose()
        {
            gameObject.SetActive(false);
            //Destroy(gameObject);
        }
       
    }
}
    
