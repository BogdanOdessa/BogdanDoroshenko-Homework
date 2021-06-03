using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public abstract class InteractiveObject : MonoBehaviour, IInteractable, IAction , System.IDisposable
    {

        //private GameController _gameController;

        public virtual void Action()
        {
            if (TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = Random.ColorHSV();
            }
        }

        public abstract void Interraction();

        private void Start()
        {
            Action();
            //_gameController = FindObjectOfType<GameController>().GetComponent<GameController>();
        }

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
            Destroy(gameObject);
        }
    }
}
    
