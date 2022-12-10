using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using TMPro;
using UnityEngine;
using UnityEngine.TestTools;

public class HippoTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void ConstructorTest()
    {
        // Use the Assert class to test conditions
        Planet planet = new Planet();
        Hippo hippo = new Hippo(planet);
        Assert.AreEqual(0, hippo.number);
        Assert.AreEqual(25, hippo.bite_capicity);
        Assert.AreEqual(0, hippo.current_storage);
        Assert.AreEqual(0.5f, hippo.percantage_bite);
    }
        
    [Test]
    public void UpdateUITest()
    {
        Planet planet = new Planet();
        Hippo hippo = new Hippo(planet);
        TMP_Text TestStorageText = new TextMeshProUGUI();
        hippo.storage_text = TestStorageText;
        hippo.updateUI();
        Assert.AreEqual("0", TestStorageText.text);
    }

    [Test]
    public void ResetHippoTest()
    {
        Planet planet = new Planet();
        Hippo hippo = new Hippo(planet);
        TMP_Text TestStorageText = new TextMeshProUGUI();
        hippo.storage_text = TestStorageText;
        hippo.current_storage = 100;
        hippo.reset_hippo();
        Assert.AreEqual(0, hippo.current_storage);
        Assert.AreEqual("0", TestStorageText.text);
    }

    [Test]
    public void TryBiteTest()
    {
        Planet planet = new Planet();
        Hippo hippo = new Hippo(planet);
        TMP_Text TestStorageText = new TextMeshProUGUI();
        hippo.storage_text = TestStorageText;
        hippo.percantage_bite = 1f;
        hippo.try_bite();
        LogAssert.Expect(LogType.Log, "Hippo 0 took 25 balls! 75 left!");
        // Assert.AreEqual(25, hippo.current_storage, $"PercentageBite is {hippo.percantage_bite}, CurrentStorage is {hippo.current_storage}.");

    }

}
