
var beacon = new Pair<Beacon>(new Beacon("A"), new Beacon("B"));
var beaconNames = new Pair<string>(beacon.First.Name, beacon.Second.Name);
var numbers = new Pair<int>(12, 24);
var magneticFields = new Pair<string>("North", "South");
var secondBeacon = new Pair<Beacon>(new Beacon("C"), new Beacon("D"));
var secondBeaconNames = new Pair<string>(secondBeacon.First.Name, secondBeacon.Second.Name);

Console.WriteLine("Paired Beacons");

PairDisplay.ShowPair(magneticFields);
PairDisplay.ShowPair(numbers);
PairDisplay.ShowPair(beaconNames);
PairDisplay.ShowPair(secondBeaconNames);
