using UnityEngine;

namespace Catalogs
{
    public class CatalogInitializator
    {
        private ScriptableObject[] _catalogs;

        private ICatalog[] catalogs;

        public void Initialize(ScriptableObject[] _catalogs)
        {
            this._catalogs = _catalogs;

            GetCatalogs();

            foreach (var catalog in catalogs)
            {
                catalog.Initialize();
            }
        }

        private void GetCatalogs()
        {
            catalogs = new ICatalog[_catalogs.Length];

            for (int i = 0; i < _catalogs.Length; i++)
            {
                catalogs[i] = (ICatalog)_catalogs[i];
            }
        }

    }
}