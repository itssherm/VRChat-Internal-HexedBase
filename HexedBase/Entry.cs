using CoreRuntime.Interfaces;
using CoreRuntime.Manager;
using Cysharp.Threading.Tasks.Linq;
using System;
using System.Collections;
using UnityEngine;





namespace HexedBase
{
    public class Entry : HexedCheat // Define the Main Class for the Loader
    {
        public override void OnLoad()
        {
            // Entry thats getting called by HexedLoader 
            Console.WriteLine("Hexed Base Cheat successfully loaded!");
            MonoManager.PatchUpdate(typeof(VRCApplication).GetMethod(nameof(VRCApplication.Update)));
            main.OnApplicationStart();
        }

        public override void OnApplicationQuit()
        {
            Console.WriteLine("Game Closed! Bye!");
        }

        public override void OnUpdate()
        {
        }

        public override void OnFixedUpdate()
        {
            // Function is not hooked, won't get called
        }

        public override void OnLateUpdate()
        {
            // Function is not hooked, won't get called
        }

        public override void OnGUI()
        {
            // Function is not hooked, won't get called
        }

    }
}
