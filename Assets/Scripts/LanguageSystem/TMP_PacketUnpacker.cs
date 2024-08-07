using TMPro;
using UnityEngine;

namespace LanguageSystem
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    [DisallowMultipleComponent]
    [AddComponentMenu("UI/TextMeshPro - Packet Unpacker")]
    public class TMP_PacketUnpacker : MonoBehaviour
    {
        [SerializeField] private TextLanguagePacket packet;
        private TMP_Text text;

        private void Start()
        {
            text = transform.GetComponent<TMP_Text>();
            packet.OnUpdated += UpdateUI;

            UpdateUI();
        }

        private void UpdateUI()
        {
            text.text = packet.outputText;
        }
    }
}