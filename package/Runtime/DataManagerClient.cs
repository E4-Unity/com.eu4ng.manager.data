using Eu4ng.Manager.Singleton;
using UnityEngine;

namespace Eu4ng.Manager.Data
{
    public abstract class DataManagerClient<TClass, TData> : MonoSingleton<TClass> where TData : class, ISavable, new() where TClass : DataManagerClient<TClass, TData>
    {
        [SerializeField] TData m_Data;

        protected TData Data => m_Data;

        /* DataManagerClient */

        protected virtual void SaveData() => DataManager.SaveData<TData>();
        protected virtual void LoadDataAsync() => DataManager.LoadDataAsync<TData>();
        protected virtual void LoadData() => m_Data = DataManager.LoadData<TData>();
        protected virtual void UnLoadData() => DataManager.UnloadData<TData>();

        /* MonoSingleton */

        protected override void OnInitialize()
        {
            LoadData();
        }

        /* MonoBehaviour */

        protected override void Awake()
        {
            base.Awake();

            LoadDataAsync();
        }

        protected override void OnDestroy()
        {
            UnLoadData();

            base.OnDestroy();
        }
    }
}
