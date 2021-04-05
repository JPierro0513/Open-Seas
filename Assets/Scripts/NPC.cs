using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yarn.Unity.Example {

    public class NPC : MonoBehaviour {

        public string characterName = "";

        public string talkToNode = "";

        [Header("Optional")]
        public YarnProgram scriptToLoad;

        void Start () {
            if (scriptToLoad != null) {
                DialogueRunner dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
                dialogueRunner.Add(scriptToLoad);                
            }
        }
    }
}
