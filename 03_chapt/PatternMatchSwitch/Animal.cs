namespace PatternMatchSwitch
{
    public class Animal
    {
        public required string Name { get; set; }
        public DateTime DOB { get; set; }
        public byte Legs { get; set; }
    }

    public class Cat : Animal { public bool IsDomestic; }

    public class Spider : Animal { public bool IsPoisonous; }

}