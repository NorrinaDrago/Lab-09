using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


public class CubeTestScript
{
    [Test]
    [TestCase(0)]
    [TestCase(-29)]
    public void DisableOnDeath_EmptyHP_ObjectSetInactive(int hp)
    {
        GameObject testObject = MakeFakeCube(hp);

        Assert.IsFalse(testObject.activeSelf);
    }

    [Test]
    [TestCase(1)]
    [TestCase(0.6f)]
    [TestCase(100)]
    [TestCase(99999)]
    public void DisableOnDeath_HasHP_ObjectRemainsActive(float hp)
    {
        GameObject testObject = MakeFakeCube(hp);

        Assert.IsTrue(testObject.activeSelf);
    }

    private static GameObject MakeFakeCube(float hp)
    {
        GameObject testObject = new GameObject();
        CubeScript cubeScript = testObject.AddComponent<CubeScript>();

        cubeScript.health = hp;
        cubeScript.DisableOnDeath();
        return testObject;
    }
}
