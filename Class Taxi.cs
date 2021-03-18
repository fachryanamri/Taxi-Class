class Taxi
{
	4 refrences
	public string DriverName { get; set; }
	4 refrences
	public bool OnDuty { get; set; }
	2 refrences
	public int NumPassenger { get; set; }
	
	1 refrences
	public void TaxiInfo()
	{
		
		Consule.WriteLine("Driver Name               : (0)", DriverName);
		
		if (OnDuty == true) {
			Consule.WriteLine("On Duty               : Yes", OnDuty);
		} else {
			Consule.WriteLine("On Duty               : No", OnDuty);
		}
		Consule.WriteLine("Number Of Passengern: {0}\n", NumPassenger);
		
	}
	
	1 refrences
	public void PickUpPassenger()
	{
		Consule.WriteLine("{0} sedang menjemput penumpang", DriveName);
	}
	
	1 refrences
	public void DropOfPassenger()
	{
		Consule.WriteLine("{0} selesai menjemput penumpang\n", DriveName);
	}
	
	Class Program
	{
		0 refrences
		static void Main(string[] args)
		{
			Taxi taxi = new Taxi();
			
			taxi.DriveName = "Ryan";
			taxi.OnDuty = false;
			taxi.NumPassenger = 10;
			
			taxi.TaxiInfo();
			taxi.PickUpPassenger();
			taxi.DropOffPassenger();
			
			Consule.ReadKey();
		}
	}