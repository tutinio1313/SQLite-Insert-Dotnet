using System;
using System.Collections.Generic;
using Newtonsoft.Json;
#pragma warning disable CS8618

namespace SqliteInsert
{
    public class ListTempClass
    {
        private static ListTempClass? lista;
        private static string TempClassJsonPath = Directory.GetCurrentDirectory() + "/db.json";
        private static List<TempClass> list;

        private ListTempClass()
        {

        }
        public static List<TempClass> getlist()
        {
            if (lista == null)
            {
                CreateLists();
            }

            return list;
        }

        private static void CreateLists()
        {

            if (lista == null)
            {
                lista = new ListTempClass();

                string jsonlist = System.IO.File.ReadAllText(TempClassJsonPath);
                list = JsonConvert.DeserializeObject<List<TempClass>>(jsonlist);

                if (list == null)
                {
                    list = new List<TempClass>();
                }
            }
        }
    }
}