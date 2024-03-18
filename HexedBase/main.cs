using CoreRuntime.Manager;
using Cysharp.Threading.Tasks.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace HexedBase
{
    internal class main
    {
        public static void OnApplicationStart()
        {
            CoroutineManager.RunCoroutine(main.waitForQM());
        }
        private static IEnumerator waitForQM()
        {
            while (GameObject.Find("Canvas_QuickMenu(Clone)") == null) yield return null; // Trys to find the Qm, if the Find Return null, it will wait for the next frame and check
            yield return null; // wait one more frame, this isn't needed, but shut up
            Console.WriteLine("Menu loaded");
            MakeMenu.MakeMainMenu();
       
           

            yield break; // This stops the IEnum
        }
    }
}
