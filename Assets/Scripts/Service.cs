using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpacePatterns
{
    public class Service : IService
    {
       public void Test()
        {
            Debug.Log(nameof(Service));
        }
    }
}
