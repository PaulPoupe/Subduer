using System;
using System.Linq;
using Legacy.Quests;
using UnityEngine;

namespace Legacy
{
    namespace Managers
    {
        public class Logbook : MonoBehaviour
        {
            [SerializeField]
            private QuestCatalog questManager;

            public static event Action<Quest> OnAddQuest;
            public static Action<Quest> OnStartQuest;

            private void Awake()
            {
                OnStartQuest += StartQuest;
                OnAddQuest += questManager.Apload;
            }

            private void AddQuest(Quest quest)
            {
                if (!questManager.GetUploaded().Any(q => q.id == quest.id))
                {
                    OnAddQuest.Invoke(quest);
                }
            }

            public void InstantiateRandomQuest()
            {
                try
                {
                    System.Random random = new System.Random();
                    AddQuest(questManager.GetNotUploaded()[random.Next(questManager.GetNotUploaded().Count)]);
                }
                catch
                {
                    Debug.LogWarning("Нет новых квестов");
                }
            }

            private void StartQuest(Quest quest) => StartCoroutine(quest.StartQuest());

        }
    }
}