using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Game
{
    public class SaveDataRepository
    {
        private readonly IData<SaveData> _data;

        private const string _folderName = "dataSave";
        private const string _fileName = "1data";
        private readonly string _path;
        private readonly PointsCounter _points;
        private InteractiveObject[] _interactiveObjects;

        private float length;
        public SaveDataRepository()
        {
            //_data = new StreamData();
            _data = new JsonData<SaveData>();
            _path = Path.Combine(Application.dataPath, _folderName);
            _points = Object.FindObjectOfType<PointsCounter>();
            _interactiveObjects = Object.FindObjectsOfType<InteractiveObject>();
        }

        public void Save(PlayerBase playerBase)
        {
            if (!Directory.Exists(Path.Combine(_path)))
            {
                Directory.CreateDirectory(_path);
            }

            var savePlayer = new SaveData
            {
                Position = playerBase.transform.position,
                Name = "Bogdan",
                IsActive = true,
                Points = _points.Totalpoints,
                InteractiveObjects = _interactiveObjects,
                LengthOfObjects = _interactiveObjects.Length
            };
           //savePlayer.InteractiveObjects = savePlayer.ConvertObjects(interactiveObjects);

            _data.Save(savePlayer, Path.Combine(_path, _fileName));

            Debug.Log(savePlayer);
        }

        public void Load(PlayerBase player)
        {
            var file = Path.Combine(_path, _fileName);
            if (!File.Exists(file)) return;

            var newPlayer = _data.Load(file);
            player.transform.position = newPlayer.Position;
            player.name = newPlayer.Name;
            player.gameObject.SetActive(newPlayer.IsActive);
            _points.Totalpoints = newPlayer.Points;

            foreach (var item in _interactiveObjects)
            {
                if (item == null) break;

                item.gameObject.SetActive(false);
            }

            foreach (var item in newPlayer.InteractiveObjects)
            {
                if (item == null) break;
                item.gameObject.SetActive(true);
            }

            Debug.Log(newPlayer);
        }

    }
}


