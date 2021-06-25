using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
<<<<<<< Updated upstream
    public abstract class InteractiveObject : MonoBehaviour, IInteractable, IAction , System.IDisposable
=======
    public abstract class InteractiveObject : MonoBehaviour, IInteractable, IAction, System.IDisposable, IExecute
>>>>>>> Stashed changes
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
            
            if (!other.gameObject.GetComponent<Player>())
                //!other.CompareTag("Player")
            {
                return;
            }
            Interraction();
            Dispose();
        }

        public void Dispose()
        {
<<<<<<< Updated upstream
            Destroy(gameObject);
        }
=======
            //gameObject.SetActive(false);
            Destroy(gameObject);
        }

>>>>>>> Stashed changes
    }
}
    
