using NUnit.Framework;

// FloorRounder特有のテスト
public class TestFloorRounder
{
    FloorRounder _target;

    [SetUp]
    public void SetUp() => _target = new FloorRounder();

    [Test]
    public void Round_ReturnsFloorValueIfEqualOrGreater()
    {
        Assert.AreEqual(0f, _target.Round(1.9f, interval: 2f));
        Assert.AreEqual(2f, _target.Round(2f, interval: 2f));
        Assert.AreEqual(2f, _target.Round(2.1f, interval: 2f));
        Assert.AreEqual(2f, _target.Round(3.9f, interval: 2f));
        Assert.AreEqual(4f, _target.Round(4f, interval: 2f));
    }
}

// FloorRounderがLSPを満たしていることのテスト
public class TestFloorRounder_LSP : TestRounderBase
{
    public override IRounder CreateTarget() => new FloorRounder();
}
