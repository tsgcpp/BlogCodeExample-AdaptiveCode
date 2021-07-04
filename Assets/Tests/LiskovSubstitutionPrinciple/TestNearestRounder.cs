using NUnit.Framework;

// NearestRounder特有のテスト
public class TestNearestRounder
{
    NearestRounder _target;

    [SetUp]
    public void SetUp() => _target = new NearestRounder();

    [Test]
    public void Round_ReturnsIntervalNearestValue()
    {
        Assert.AreEqual(2f, _target.Round(1.9f, interval: 2f));
        Assert.AreEqual(2f, _target.Round(2f, interval: 2f));
        Assert.AreEqual(2f, _target.Round(2.1f, interval: 2f));
    }
}

// NearestRounderがLSPを満たしていることのテスト
public class TestNearestRounder_LSP : TestRounderBase
{
    public override IRounder CreateTarget() => new NearestRounder();
}
