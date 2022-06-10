using System;

public class Car
// Create a seperate class file called Car
//Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
{
	public string Year { get; set; }
	public string Make { get; set; }
	public string Model { get; set; }
	public string EngineNoise { get; set; }
	public string HonkNoise { get; set; }
	public bool IsDriveable { get; set; }
	//Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
	//The methods should take one string parameter: the respective noise property

	public void MakeEngineNoise(string noise) {
		EngineNoise = noise;
		Console.WriteLine(noise);
	}
	public void MakeHonkNoise(string noise)
	{
		HonkNoise = noise;
		Console.WriteLine(noise);

	}


	public Car()
	{
	}
	public Car(string year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
    {
		Year = year;
		Make = make;
		Model = model;
		EngineNoise = engineNoise;
		HonkNoise = honkNoise;
		IsDriveable = isDriveable;
	}
}
