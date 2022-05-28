using System.Collections;
using UnityEngine;

namespace SpacePatterns
{
    internal sealed class LockShooting : MonoBehaviour
    {
        public static bool CantShoot { get; private set; }
        private static float timeInSec = 5.0f;

        public void GetLocked()
        {
            CantShoot = true;
            StartCoroutine(CantShootForTime());
        }

        private IEnumerator CantShootForTime()
        {
            yield return new WaitForSeconds(timeInSec);
            CantShoot = false;
        }
    }
}
