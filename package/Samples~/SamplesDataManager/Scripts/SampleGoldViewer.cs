using TMPro;
using UnityEngine;

namespace Eu4ng.Manager.Data.Sample
{
    public class SampleGoldViewer : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] TextMeshProUGUI m_GoldText;

        void Awake()
        {
            if(m_GoldText == null) m_GoldText = GetComponent<TextMeshProUGUI>();
        }

        void Start()
        {
            m_GoldText.SetText("Gold: " + SampleDataManagerClient.Instance.Gold);
        }
    }
}
