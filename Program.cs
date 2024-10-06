using System;
using System.Collections.Generic;
namespace DoFactory.GangOfFour.Factory.RealWorld
{
    /// <summary> 
    /// MainApp startup class for Real-World 
    /// Factory Method Design Pattern. 
    /// </summary> 
    class MainApp
    {
        /// <summary> 
        /// Entry point into console application. 
        /// </summary> 
        static void Main()
        {
            // Note: constructors call Factory Method 
            VehicleCreator[] VehicleCreators = new VehicleCreator[3];
            VehicleCreators[0] = new SUVCreator();
            VehicleCreators[1] = new SedanCreater();
            VehicleCreators[2] = new SedanCreater();
            // Display document pages 
            foreach (VehicleCreator aVehicleCreator in VehicleCreators)
            {
                Console.WriteLine("\n" + aVehicleCreator.GetType().Name + "--");
                foreach (Feature feature in aVehicleCreator.CurrentVehicle.GetFeatures())
                {
                    Console.WriteLine(" " + feature.GetType().Name);
                }

            }

            // Wait for user 
            Console.ReadKey();
        }
    }
    /// <summary> 
    /// The 'Product' abstract class 
    /// </summary> 
    abstract class Feature
    {
    }
    /// <summary> 
    /// A 'ConcreteProduct' class 
    /// </summary> 
    class ABS : Feature
    {
    }
    /// <summary> 
    /// A 'ConcreteProduct' class 
    /// </summary> 
    class EngineCapicity : Feature
    {
    }
    /// <summary> 
    /// A 'ConcreteProduct' class 
    /// </summary> 
    class CruiseControl : Feature
    {
    }
    /// <summary> 
    /// A 'ConcreteProduct' class 
    /// </summary> 
    class Hybrid : Feature
    {
    }
    /// <summary> 
    /// A 'ConcreteProduct' class 
    /// </summary> 
    class echoMode : Feature
    {
    }
    /// <summary> 
    /// A 'ConcreteProduct' class 
    /// </summary> 
    class pushStart : Feature
    {
    }
    /// <summary> 
    /// A 'ConcreteProduct' class 
    /// </summary> 
    class ButtonStart : Feature
    {
    }
    /// <summary> 
    /// A 'ConcreteProduct' class 
    /// </summary> 
    class RemoteStart : Feature
    {
    }
    /// <summary> 
    /// The 'Abstract Product' Document 
    /// </summary> 
    abstract class Vehicle
    {
        protected List<Feature> ListOfFeatures = new List<Feature>();
        // Constructor calls abstract Factory method 
        public Vehicle()
        {

        }

        public void AddFeatures(Feature aFeature)
        {
            ListOfFeatures.Add(aFeature);
        }

        public List<Feature> GetFeatures()
        {
            return ListOfFeatures;
        }
    }
  
    class SUV : Vehicle
    {

    }
   

    class Sedan : Vehicle
    {

    }
    class HatchBack : Vehicle
    {

    }
    /// <summary> 
    /// The 'Abstract Product Creator' VehicleCreater 
    /// </summary> 
    abstract class VehicleCreator
    {
        private Vehicle objVehicle;
        // Constructor calls abstract Factory method 

        public Vehicle CurrentVehicle
        {
            get { return objVehicle; }
            set { objVehicle = value; }
        }
        // Factory Method 
        public abstract void CreateVehicle();
    }
    /// <summary> 
    /// A 'Concrete Product' Sedan class 
    /// </summary> 
    class SedanCreater : VehicleCreator
    {

        public SedanCreater()
        {
            this.CurrentVehicle = new Sedan();
            CreateVehicle();
        }
        // Factory Method implementation 
        public override void CreateVehicle()
        {
            CurrentVehicle.AddFeatures(new pushStart());
            CurrentVehicle.AddFeatures(new echoMode());
        }
    }
    /// <summary> 
    /// A 'Concrete Product' Report class 
    /// </summary> 
    class SUVCreator : VehicleCreator
    {

        public SUVCreator()
        {
            this.CurrentVehicle = new Sedan();
            CreateVehicle();
        }
        // Factory Method implementation 
        public override void CreateVehicle()
        {
            CurrentVehicle.AddFeatures(new ButtonStart());
            CurrentVehicle.AddFeatures(new Hybrid());
            CurrentVehicle.AddFeatures(new CruiseControl());
        }
    }

    class HatchBackCreator : VehicleCreator
    {

        public HatchBackCreator()
        {
            this.CurrentVehicle = new HatchBack();
            CreateVehicle();
        }
        // Factory Method implementation 
        public override void CreateVehicle()
        {
           CurrentVehicle.AddFeatures(new RemoteStart());
            CurrentVehicle.AddFeatures(new EngineCapicity());
            CurrentVehicle.AddFeatures(new ABS());
        }
    }
}