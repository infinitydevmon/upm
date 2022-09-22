
namespace com.addressable.extends
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class TestScript : MonoBehaviour
    {
        static TestScript instance;

        public static TestScript Instance
        {
            get
            {
                if (instance == null)
                {
                    var go = new GameObject();
                    go.transform.parent = GameObject.Find("UI Root").transform;
                    go.transform.localScale = Vector3.one;
                    go.transform.localPosition = Vector3.zero;
                    instance = go.GetComponent<TestScript>();
                }

                return instance;
            }
        }

        public void Display()
        {
        }
    }
}