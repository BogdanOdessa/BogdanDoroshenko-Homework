using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.Linq;
using System.IO;
namespace Game
{
    public class StreamData : IData<SaveData>
    {
        public void Save(SaveData data, string path = null)
        {
            if (path == null) return;
            using (var sw = new StreamWriter(path))
            {
                sw.WriteLine(data.Name);
                
                sw.WriteLine(data.Position.X);
                sw.WriteLine(data.Position.Y);
                sw.WriteLine(data.Position.Z);
                sw.WriteLine(data.IsActive);
                sw.WriteLine(data.Points);

                sw.WriteLine(data.InteractiveObjects.Length);
                for (int i = 0; i < data.InteractiveObjects.Length; i++)
                {
                    sw.WriteLine(data.InteractiveObjects[i].name);
                } 
            }
           
        }

        public SaveData Load(string path = null)
        {
            var result = new SaveData();

            using (var sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    result.Name = sr.ReadLine();
                   
                  
                    result.Position.X = Convert.ToSingle(sr.ReadLine());
                    result.Position.Y = Convert.ToSingle(sr.ReadLine());
                    result.Position.Z = Convert.ToSingle(sr.ReadLine());
                    result.IsActive = Convert.ToBoolean(sr.ReadLine());
                    result.Points = Convert.ToSingle(sr.ReadLine());

                    result.LengthOfObjects = Convert.ToSingle(sr.ReadLine());

                    for (int i = 0; i < result.LengthOfObjects; i++)
                    {
                        result.listOfInteractiveObjects[i] = sr.ReadLine();
                    }
                }
            }
            return result;
        }

    }

}
