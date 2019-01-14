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
        public void DogCanEatFromCorgi()
        {
            Corgi testCorgi = new Corgi();
            string testMessage = testCorgi.Eat();
            Dog testDog = new Corgi();
            string dogMessage = testDog.Eat();
            Assert.Equal(dogMessage, testMessage);
        }
        [Fact]
        public void MammalCanBrushSelfFromCorgi()
        {
            Corgi testCorgi = new Corgi();
            string testMessage = testCorgi.BrushSelf();
            Mammal testMammal = new Corgi();
            string mammalMessage = testMammal.BrushSelf();
            Assert.Equal(mammalMessage, testMessage);
        }
        [Fact]
        public void AnimalCanWalkFromCorgi()
        {
            Corgi testCorgi = new Corgi();
            string testMessage = testCorgi.Walk();
            Animal testAnimal = new Corgi();
            string animalMessage = testAnimal.Walk();
            Assert.Equal(animalMessage, testMessage);
        }


    }
}
