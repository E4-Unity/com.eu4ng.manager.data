using System;

namespace Eu4ng.Manager.Data.Sample
{
    [Serializable]
    public class SampleSaveData : ISavable
    {
        public int Gold;
    }

    public class SampleDataManagerClient : DataManagerClient<SampleDataManagerClient, SampleSaveData>
    {
        public int Gold
        {
            get => Data.Gold;
            set
            {
                Data.Gold = value;
                SaveData();
            }
        }

        /* MonoSingleton */

        protected override void OnInitialize()
        {
            base.OnInitialize();

            ++Gold;
        }
    }
}
