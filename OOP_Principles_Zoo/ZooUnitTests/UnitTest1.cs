using System;
using Xunit;
using OOP_Principles_Zoo.Classes;

namespace ZooUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CorgiCanEat()
        {
            Corgi testCorgi = new Corgi();
            string testMessage = testCorgi.Eat();
            Assert.Equal("The " + testCorgi.AnimalName + " is eating some kibble.", testMessage);
        }
        [Fact]
        public void CorgiCanWalk()
        {
            Corgi testCorgi = new Corgi();
            string testMessage = testCorgi.Walk();
            Assert.Equal("Please walk the " + testCorgi.AnimalName + ".", testMessage);
        }
        [Fact]
        public void CorgiCanBrushSelf()
        {
            Corgi testCorgi = new Corgi();
            string testMessage = testCorgi.BrushSelf();
            Assert.Equal("The " + testCorgi.AnimalName + " is brushing their own coat.", testMessage);
        }
        [Fact]
        public void CorgiCanGrowSecondCoatBrushSelf()
        {
            Corgi testCorgi = new Corgi();
            testCorgi.HasTwoCoats = true;
            string testMessage = testCorgi.BrushSelf();
            Assert.Equal("The " + testCorgi.AnimalName + " is brushing their own coat. The " + testCorgi.AnimalName + "'s second coat sheds.", testMessage);
        }
        [Fact]
        public void CorgiCanBark()
        {
            Corgi testCorgi = new Corgi();
            string testMessage = testCorgi.Bark();
            Assert.Equal("The " + testCorgi.AnimalName + " barks quietly.", testMessage);
        }
        [Fact]
        public void CorgiCanFlop()
        {
            Corgi testCorgi = new Corgi();
            string testMessage = testCorgi.Flop();
            Assert.Equal("The corgi flops on the ground.", testMessage);
        }
        [Fact]
        public void CorgiDoesNotEatFromDog()
        {
            Corgi testCorgi = new Corgi();
            string testMessage = testCorgi.Walk();
            Dog testDog = new Corgi();
            string dogMessage = testDog.Eat();
            Assert.NotEqual(dogMessage, testMessage);
        }
        
    }
}
