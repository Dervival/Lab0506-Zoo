using System;
using Xunit;
using OOP_Principles_Zoo.Classes;
using OOP_Principles_Zoo.Interfaces;

namespace ZooUnitTests
{
    public class UnitTest1
    {
        //Corgi tests
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

        //Samoyed tests
        [Fact]
        public void SamoyedCanSamoyedEat()
        {
            Samoyed testSamoyed = new Samoyed();
            string testMessage = testSamoyed.SamoyedEat();
            Assert.Equal("The white " + testSamoyed.AnimalName + " says: I am eating some kibble.", testMessage);
        }
        [Fact]
        public void SamoyedEatAndEatAreDistinct()
        {
            Samoyed testSamoyed = new Samoyed();
            string testMessage = testSamoyed.SamoyedEat();
            string testMessageTwo = testSamoyed.Eat();
            Assert.NotEqual(testMessage, testMessageTwo);
        }
        [Fact]
        public void SamoyedCanWalk()
        {
            Samoyed testSamoyed = new Samoyed();
            string testMessage = testSamoyed.Walk();
            Assert.Equal("Please walk the " + testSamoyed.AnimalName + ".", testMessage);
        }
        [Fact]
        public void SamoyedCanBrushSelf()
        {
            Samoyed testSamoyed = new Samoyed();
            string testMessage = testSamoyed.BrushSelf();
            Assert.Equal("The " + testSamoyed.AnimalName + " is brushing their own coat. The " + testSamoyed.AnimalName + "'s second coat sheds.", testMessage);
        }
        [Fact]
        public void SamoyedCanBark()
        {
            Samoyed testSamoyed = new Samoyed();
            string testMessage = testSamoyed.Bark();
            Assert.Equal("The " + testSamoyed.AnimalName + " howls.", testMessage);
        }
        [Fact]
        public void SamoyedCanRollOver()
        {
            Samoyed testSamoyed = new Samoyed();
            string testMessage = testSamoyed.RollOver();
            Assert.Equal("The samoyed rolls on the ground, making their coat dirty.", testMessage);
        }

        //Pidgeon tests
        [Fact]
        public void PidgeonCanEat()
        {
            Pidgeon testPidgeon = new Pidgeon();
            string testMessage = testPidgeon.Eat();
            Assert.Equal("The Pidgeon is eating some birdseed.", testMessage);
        }
        [Fact]
        public void PidgeonCanFlap()
        {
            Pidgeon testPidgeon = new Pidgeon();
            string testMessage = testPidgeon.Flap();
            Assert.Equal("The pidgeon flutters its wings.", testMessage);
        }
        [Fact]
        public void PidgeonCanCoo()
        {
            Pidgeon testPidgeon = new Pidgeon();
            string testMessage = testPidgeon.Coo();
            Assert.Equal("The pidgeon goes 'Coo!'", testMessage);
        }

        [Fact]
        public void PidgeonInheritsWalk()
        {
            //Walk is in Bird, not Pidgeon
            Pidgeon testPidgeon = new Pidgeon();
            string testMessage = testPidgeon.Walk();
            Assert.Equal("The Pidgeon walks around its nest in the city.", testMessage);
        }
        [Fact]
        public void PidgeonInheritsLivesIn()
        {
            //LivesIn is in Bird
            Pidgeon testPidgeon = new Pidgeon();
            Assert.Equal("city", testPidgeon.LivesIn);
        }
        //Eagle tests
        [Fact]
        public void EagleCanEat()
        {
            Eagle testEagle = new Eagle();
            string testMessage = testEagle.Eat();
            Assert.Equal("The eagle is now eating a mouse.", testMessage);
        }
        [Fact]
        public void EagleCanFlap()
        {
            Eagle testEagle = new Eagle();
            string testMessage = testEagle.Flap();
            Assert.Equal("The eagle spreads its wings.", testMessage);
        }

        [Fact]
        public void EagleOverridesLivesIn()
        {
            //LivesIn is in Bird
            Bird testBird = new Pidgeon();
            Eagle testEagle = new Eagle();
            Assert.NotEqual(testEagle.LivesIn, testBird.LivesIn);
        }
        [Fact]
        public void EagleInheritsWalk()
        {
            //Walk is in Bird, not Pidgeon
            Eagle testEagle = new Eagle();
            string testMessage = testEagle.Walk();
            Assert.Equal("The Eagle walks around its nest in the Countryside.", testMessage);
        }
        
        //Snake tests
        [Fact]
        public void SnakeCanHibernateThroughInterface()
        {
            IHibernate testSnake = new Snake();
            testSnake.IsHibernating = false;
            string hibernateMessage = testSnake.StartHibernating();
            Assert.Equal("The snake begins to hibernate.", hibernateMessage);
        }
        [Fact]
        public void SnakeCanHibernateOnlyWhenNotHibernating()
        {
            IHibernate testSnake = new Snake();
            testSnake.IsHibernating = true;
            string hibernateMessage = testSnake.StartHibernating();
            Assert.Equal("The snake is already hibernating!", hibernateMessage);
        }
        [Fact]
        public void SnakeCanStopHibernatingThroughInterface()
        {
            IHibernate testSnake = new Snake();
            testSnake.IsHibernating = true;
            string hibernateMessage = testSnake.StopHibernating();
            Assert.Equal("The snake stops hibernating.", hibernateMessage);
        }
        [Fact]
        public void SnakeCanStopHibernatingOnlyWhenCurrentlyHibernating()
        {
            IHibernate testSnake = new Snake();
            testSnake.IsHibernating = false;
            string hibernateMessage = testSnake.StopHibernating();
            Assert.Equal("The snake is not hibernating, so cannot stop hibernating.", hibernateMessage);
        }
        //Dragon tests
        [Fact]
        public void DragonCanHibernateThroughInterface()
        {
            IHibernate testDragon = new Dragon();
            testDragon.IsHibernating = false;
            string hibernateMessage = testDragon.StartHibernating();
            Assert.Equal("The dragon begins to hibernate.", hibernateMessage);
        }
        [Fact]
        public void DragonCanStopHibernatingThroughInterface()
        {
            IHibernate testDragon = new Dragon();
            testDragon.IsHibernating = true;
            string hibernateMessage = testDragon.StopHibernating();
            Assert.Equal("The dragon stops hibernating.", hibernateMessage);
        }
        [Fact]
        public void DragonCanTakeOff()
        {
            IFly testDragon = new Dragon();
            testDragon.IsFlying = false;
            string flyMessage = testDragon.TakeOff();
            Assert.Equal("The dragon takes flight!", flyMessage);
        }
        [Fact]
        public void DragonCanLand()
        {
            IFly testDragon = new Dragon();
            testDragon.IsFlying = true;
            string flyMessage = testDragon.Land("home");
            Assert.Equal("The dragon lands at home.", flyMessage);
        }
    }
}
