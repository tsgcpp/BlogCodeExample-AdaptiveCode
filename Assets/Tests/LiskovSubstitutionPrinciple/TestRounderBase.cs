using NUnit.Framework;

public abstract class TestRounderBase
{
    // abstract指定で継承クラスのテストクラスのインスタンス生成を定義させる
    public abstract IRounder CreateTarget();

    IRounder _target;

    [SetUp]
    public void SetUp() => _target = CreateTarget();

    // 事後条件1: 引数のvalueとintervalが同じ値の場合はintervalを返すこと
    [Test]
    public void Round_ReturnsIntervalIfValueIsEqualToInterval()
    {
        Assert.AreEqual(1f, _target.Round(1f, interval: 1f));
        Assert.AreEqual(2f, _target.Round(2f, interval: 2f));
        Assert.AreEqual(10f, _target.Round(10f, interval: 10f));
    }

    // 事前条件1: intervalに0は指定不可として、例外を出すこと
    [Test]
    public void Round_ThrowsExceptionIfIntervalIsZero()
    {
        Assert.Throws<RounderException>(() =>
        {
            _target.Round(1f, interval: 0f);
        });
    }

    // 事前条件2: intervalに負の値は指定不可として、例外を出すこと
    [Test]
    public void Round_ThrowsExceptionIfIntervalIsLessThanZero()
    {
        Assert.Throws<RounderException>(() =>
        {
            _target.Round(1f, interval: -1f);
        });
    }
}
