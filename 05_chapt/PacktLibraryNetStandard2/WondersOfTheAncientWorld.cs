using Packt.Shared;

[Flags]  // this decoration allows for a combination of values to be stored in a single variable or field
public enum WondersOfTheAncientWorld : byte
{
    // explicit byte values for each enum so they don't overlap
    None = 0b_0000_0000, // i.e., 0
    GreatPyramidOfGiza = 0b_0000_0001, // i.e., 1
    HangingGardensOfBabylon = 0b_0000_0010, // i.e., 2
    StatueOfZeusAtOlympia = 0b_0000_0100, // i.e., 4
    TempleOfArtemisAtEphesus = 0b_0000_1000, // i.e., 8
    MausoleumAtHalicarnassus = 0b_0001_0000, // i.e., 16
    ColossusOfRhodes = 0b_0010_0000, // i.e., 32
    LighthouseOfAlexandria = 0b_0100_0000 // i.e., 64
}