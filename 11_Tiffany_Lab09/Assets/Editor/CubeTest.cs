using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CubeTest
    {
        [Test]
        [TestCase(0)]
        [TestCase(-26)]
        public void DisableOnDeath_EmptyHP_ObjectSetInactive(float HP)
        {
            GameObject testObject = MakeFakeCube(HP);

            Assert.IsFalse(testObject.activeSelf);
        }

        [Test]
        [TestCase(1)]
        [TestCase(0.6f)]
        [TestCase(100)]
        [TestCase(9999)]
        public void DisableOnDeath_HasHP_ObjectRemainactive(float HP)
        {
            GameObject testObject = MakeFakeCube(HP);

            Assert.IsTrue(testObject.activeSelf);
        }

        private static GameObject MakeFakeCube(float HP)
        {
            GameObject testObject = new GameObject();
            Cube cubeScript = testObject.AddComponent<Cube>();

            cubeScript.Health = HP;
            cubeScript.DisableOnDeath();
            return testObject;
        }
    }
}
