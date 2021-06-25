using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class MiniMap : MonoBehaviour
    {
        private Transform _player;

        private Player player;

        private void Start()
        {
            player = FindObjectOfType<Player>();
            _player = Camera.main.transform;
            transform.parent = null;
            transform.rotation = Quaternion.Euler(90f, 0, 0);
            transform.position = _player.position + new Vector3(0f, 5f, 0f) - new Vector3(0f, 0f, 10f);

            var rt = Resources.Load<RenderTexture>("MiniMapTexture");

            GetComponent<Camera>().targetTexture = rt;


        }

        private void LateUpdate()
        {
            var newPosition = _player.position;
            newPosition.y = transform.position.y;
            transform.position = newPosition;
            transform.rotation = Quaternion.Euler(90, _player.eulerAngles.y, 0);
        }

    }
}

