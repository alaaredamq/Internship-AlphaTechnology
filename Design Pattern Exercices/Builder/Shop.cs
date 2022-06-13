namespace Design_Pattern_Exercices.Builder; 

class Shop {
    
    public void Construct(VehicleBuilder vehicleBuilder) {
        vehicleBuilder.BuildFrame();
        vehicleBuilder.BuildEngine();
        vehicleBuilder.BuildWheels();
        vehicleBuilder.BuildDoors();
    }
}