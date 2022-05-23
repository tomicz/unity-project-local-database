using System.IO;
using UnityEngine;

namespace TOMICZ.Database
{
    public class Database
    {
        private string _databaseName;

        private string PathName
        {
            get
            {
                return Application.persistentDataPath + _databaseName;
            }
        }

        public Database(string databaseName)
        {
            _databaseName = "/" + databaseName + ".json";
        }

        public void AppendData(Data data)
        {
            using(StreamWriter streamWriter = new StreamWriter(PathName))
            {
                streamWriter.WriteLine(JsonUtility.ToJson(data));
            }
        }
    }
}